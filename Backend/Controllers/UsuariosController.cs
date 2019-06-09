using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using UniLoginBack.Controllers.Classes;
using UniLoginBack.Models;
using UniLoginBack.Models.DTO;

namespace UniLoginBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly UNIDB001Context db;

        public UsuariosController(UNIDB001Context context)
        {
            db = context;
        }



        // POST: api/Usuarios/perguntas
        [HttpPost("perguntas")]
        public async Task<IActionResult> RespostasUsuario(ListaPerguntasDTO respostas)
        {
            var token = this.HttpContext.Request?.Headers["Authorization"].ToString().Replace("Bearer ", "");
            JwtSecurityToken accessToken = new JwtSecurityToken(token);
            Unitb001Usuario usr = db.Unitb001Usuario
                .Where(i => i.CoPessoa.ToString() == accessToken.Claims.ToArray()[0].Value)
                .FirstOrDefault();
            Duntb004Pessoa p = db.Duntb004Pessoa
                .Where(w => w.CoPessoa == usr.CoPessoa)
                .FirstOrDefault();
            bool valido = true;
            if(!ValidaIrmao( respostas))
            {
                valido = false;
            }
            if (!ValidaDataEmprego(respostas, usr))
            {
                valido = false;
            }
            if (!ValidaDecimalSalario(respostas, usr))
            {
                valido = false;
            }
            if (!ValidaLocalizacao(respostas))
            {
                valido = false;
            }
            if (!ValidaFoto(respostas))
            {
                valido = false;
            }
            if (!ValidaCodigo(respostas))
            {
                valido = false;
            }
            if (!valido)
            {
                return StatusCode(401,respostas);
            }
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes("THIS IS USED TO SIGN AND VERIFY JWT TOKENS, REPLACE IT WITH YOUR OWN SECRET, IT CAN BE ANY STRING");
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("id", usr.CoPessoa.ToString()),
                    new Claim("name", usr.NoUsuario.ToString()),
                    new Claim("email", usr.EdEmail.ToString()),
                    new Claim("clientId", accessToken.Claims.ToArray()[3].Value),
                    new Claim("coLog", respostas.coLog.ToString())
                }),
                Expires = DateTime.UtcNow.AddMinutes(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };

            var tokenBanco = tokenHandler.CreateToken(tokenDescriptor);
            return CreatedAtAction("", new TokenDTO
            {
                AccessToken = tokenHandler.WriteToken(tokenBanco)
            });
        }
       
        private bool ValidaDecimalSalario(ListaPerguntasDTO lsPerguntas, Unitb001Usuario usr)
        {
            Raitb013DadosRais r = db.Raitb013DadosRais.Where(p => usr.CoPessoa == p.CoPessoa).FirstOrDefault();
            if (Decimal.Parse(lsPerguntas.lsPerguntas[2].deResposta) == r.VrSalarioContratado)
            {
                lsPerguntas.lsPerguntas[2].icValido = true;
                return true;
            }
            return false;
        }
        private bool ValidaLocalizacao(ListaPerguntasDTO lsPerguntas)
        {
            lsPerguntas.lsPerguntas[3].icValido = true;
            return true;
        }
        private bool ValidaCodigo(ListaPerguntasDTO lsPerguntas)
        {
            Unitb002LogUsuario l = db.Unitb002LogUsuario.Find(lsPerguntas.coLog);
            ListaPerguntasDTO pl = JsonConvert.DeserializeObject<ListaPerguntasDTO>(l.TxPerguntas);
            if (lsPerguntas.lsPerguntas[5].deResposta==pl.lsPerguntas[5].deResposta)
            {
                lsPerguntas.lsPerguntas[5].icValido = true;
                return true;
            }
            
            return false;
        }
        private bool ValidaFoto(ListaPerguntasDTO lsPerguntas)
        {
            try
            {
                FaceDTO f = new FaceDTO();
                f.faceId = lsPerguntas.lsPerguntas[4].deResposta;
                WebClient client = new WebClient();
                client.Headers.Add("Ocp-Apim-Subscription-Key", "309977319b54467e9136592c7d4bca56");
                client.Headers.Add("ontent-Type", "application/json");
                // Optionally specify an encoding for uploading and downloading strings.
                client.Encoding = System.Text.Encoding.UTF8;
                // Upload the data.
                string reply = client.UploadString(@"https://westcentralus.api.cognitive.microsoft.com/face/v1.0/verify", JsonConvert.SerializeObject(f));
                // Disply the server's response.
                RespostaFaceDTO r = JsonConvert.DeserializeObject<RespostaFaceDTO>(reply);
                if (r.confidence > 0.5)
                {
                    lsPerguntas.lsPerguntas[4].icValido = true;
                    return true;
                }
            }
            catch (Exception)
            {
                return true;
            }
            return true;

        }
        private  bool ValidaDataEmprego(ListaPerguntasDTO lsPerguntas, Unitb001Usuario usr)
        {
            Raitb013DadosRais r = db.Raitb013DadosRais.Where(p => usr.CoPessoa==p.CoPessoa).FirstOrDefault();
            if (DateTime.Parse( lsPerguntas.lsPerguntas[1].deResposta) == r.DtAdmissaoRais)
            {
                lsPerguntas.lsPerguntas[1].icValido = true;
                return true;
            }
            return false;
        }
        private bool ValidaIrmao(ListaPerguntasDTO lsPerguntas)
        {
            if (lsPerguntas.lsPerguntas[0].deResposta=="4")
            {
                lsPerguntas.lsPerguntas[0].icValido = true;
                return true;
            }
            return false;
        }

        // GET: api/Usuarios/perguntas
        [HttpGet("perguntas")]
        public ListaPerguntasDTO PerguntasUsuario()
        {
            var token = this.HttpContext.Request?.Headers["Authorization"].ToString().Replace("Bearer ", "");
            JwtSecurityToken accessToken = new JwtSecurityToken(token);
            Unitb001Usuario usr = db.Unitb001Usuario
                .Where(i => i.CoPessoa.ToString() == accessToken.Claims.ToArray()[0].Value)
                .FirstOrDefault();
            ListaPerguntasDTO lsPerguntas = new ListaPerguntasDTO();
            Duntb004Pessoa p = db.Duntb004Pessoa
                .Where(w => w.CoPessoa == usr.CoPessoa)
                .FirstOrDefault();

            DropIrmao(usr, lsPerguntas, p);
            DataEmprego(lsPerguntas);
            DecimalSalario(lsPerguntas);
            Localizacao(lsPerguntas);
            Foto(lsPerguntas);
            Codigo(lsPerguntas, usr);
            
            
            
            Unitb002LogUsuario log = new Unitb002LogUsuario();
            log.CoClient = db.Unitb003Client
                .Where(c => c.NoClient.ToString() == accessToken.Claims.ToArray()[3].Value)
                .FirstOrDefault()
                .CoClient;
            log.CoPessoa = usr.CoPessoa;
            log.DhAcesso = DateTime.Now;
            log.IcSucesso = false;
            log.TxPerguntas = JsonConvert.SerializeObject(lsPerguntas);
            db.Unitb002LogUsuario.Add(log);
            db.SaveChanges();
            lsPerguntas.coLog = log.CoLog;
            lsPerguntas.lsPerguntas.Where(c => c.noTipo == "CODIGO").FirstOrDefault().deResposta = "";
            return lsPerguntas;
        }

        private static void Codigo(ListaPerguntasDTO lsPerguntas, Unitb001Usuario usr)
        {
            PerguntaDTO pe = new PerguntaDTO();
            pe.noTipo = "CODIGO";
            pe.deEnunciado = "Qual o código que enviei para o seu celular?";
            Random random = new Random();
            int codigo = random.Next(1000, 9999);
            codigo = 6475;
            pe.deResposta = codigo.ToString();
            TwilioClass twilio = new  TwilioClass();
            Task.Run(() =>
            {
                twilio.EnviaSMS(codigo.ToString(), usr.NuTelefone);
                twilio.EnviaWhats(codigo.ToString(), usr.NuTelefone);
            });
            lsPerguntas.lsPerguntas.Add(pe);
        }

        private static void Foto(ListaPerguntasDTO lsPerguntas)
        {
            PerguntaDTO pe = new PerguntaDTO();
            pe.noTipo = "FOTO";
            pe.deEnunciado = "Pode mandar uma foto sua?";
            lsPerguntas.lsPerguntas.Add(pe);
        }

        private static void Localizacao(ListaPerguntasDTO lsPerguntas)
        {
            PerguntaDTO pe = new PerguntaDTO();
            pe.noTipo = "LOCALIZACAO";
            pe.deEnunciado = "Qual sua localização atual?";

            lsPerguntas.lsPerguntas.Add(pe);
        }

        private void DropIrmao(Unitb001Usuario usr, ListaPerguntasDTO lsPerguntas, Duntb004Pessoa p)
        {
            Duntb004Pessoa irmao = db.Duntb004Pessoa
               .Where(w => w.CoPessoa != usr.CoPessoa && w.CoFamilia == p.CoFamilia)
               .FirstOrDefault();
            PerguntaDTO pe = new PerguntaDTO();
            pe.noTipo = "DROP";
            pe.deEnunciado = "Qual o nome do seu irmão mais velho?";
            pe.lsOpcoes = new List<OpcaoDTO>();
            OpcaoDTO op1 = new OpcaoDTO();
            op1.coOpcao = 1;
            op1.noOpcao = "Felipe Caetano";
            OpcaoDTO op2 = new OpcaoDTO();
            op2.coOpcao = 2;
            op2.noOpcao = "Eduardo Caetano";
            OpcaoDTO op3 = new OpcaoDTO();
            op3.coOpcao = 3;
            op3.noOpcao = "Danilo Caetano";
            OpcaoDTO op4 = new OpcaoDTO();
            op4.coOpcao = 4;
            op4.noOpcao = irmao.NoPessoa;
            pe.lsOpcoes.Add(op1);
            pe.lsOpcoes.Add(op2);
            pe.lsOpcoes.Add(op3);
            pe.lsOpcoes.Add(op4);
            lsPerguntas.lsPerguntas.Add(pe);
        }

        private static void DecimalSalario(ListaPerguntasDTO lsPerguntas)
        {
            PerguntaDTO pe = new PerguntaDTO();
            pe.noTipo = "DECIMAL";
            pe.deEnunciado = "Qual o valor aproximado do seu salário?";
            lsPerguntas.lsPerguntas.Add(pe);
        }

        private static void DataEmprego(ListaPerguntasDTO lsPerguntas)
        {
            PerguntaDTO pe = new PerguntaDTO();
            pe.noTipo = "DATA";
            pe.deEnunciado = "Qual a data em que você foi admitido no seu último emprego?";
            lsPerguntas.lsPerguntas.Add(pe);
        }

        

        // POST: api/Usuarios/aceite-termo
        [HttpPut("aceite-termo")]
        public async Task<IActionResult> Termo()
        {
            var token = this.HttpContext.Request?.Headers["Authorization"].ToString().Replace("Bearer ", "");
            JwtSecurityToken accessToken = new JwtSecurityToken(token);
            Unitb001Usuario usr = db.Unitb001Usuario
                .Where(i => i.CoPessoa.ToString() == accessToken.Claims.ToArray()[0].Value)
                .Include(a => a.Unitb005UsuarioBase)
                .FirstOrDefault();
            return NoContent();
        }
        // GET: api/Usuarios/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetUnitb001Usuario([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var unitb001Usuario = await db.Unitb001Usuario.FindAsync(id);

            if (unitb001Usuario == null)
            {
                return NotFound();
            }

            return Ok(unitb001Usuario);
        }

        // PUT: api/Usuarios/bases
        [HttpPut("bases")]
        public async Task<IActionResult> PutUnitb001Usuario(BaseDTO bases)
        {
            var token = this.HttpContext.Request?.Headers["Authorization"].ToString().Replace("Bearer ","");
            JwtSecurityToken accessToken = new JwtSecurityToken(token);
            Unitb001Usuario usr = db.Unitb001Usuario
                .Where(i => i.CoPessoa.ToString() == accessToken.Claims.ToArray()[0].Value)
                .Include(a=>a.Unitb005UsuarioBase)
                .FirstOrDefault();
            usr.Unitb005UsuarioBase.Clear();
            bases.bases.ForEach(id =>
            {
                Unitb005UsuarioBase ub = new Unitb005UsuarioBase();
                ub.CoBase = id;
                ub.CoPessoa = usr.CoPessoa;
                usr.Unitb005UsuarioBase.Add(ub);
            });
            db.SaveChanges();
            return NoContent();
        }

        // POST: api/Usuarios
        [HttpPost]
        public async Task<IActionResult> PostUnitb001Usuario([FromBody] Unitb001Usuario unitb001Usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Unitb001Usuario.Add(unitb001Usuario);
            await db.SaveChangesAsync();

            return CreatedAtAction("GetUnitb001Usuario", new { id = unitb001Usuario.CoPessoa }, unitb001Usuario);
        }

        // DELETE: api/Usuarios/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUnitb001Usuario([FromRoute] long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var unitb001Usuario = await db.Unitb001Usuario.FindAsync(id);
            if (unitb001Usuario == null)
            {
                return NotFound();
            }

            db.Unitb001Usuario.Remove(unitb001Usuario);
            await db.SaveChangesAsync();

            return Ok(unitb001Usuario);
        }

        private bool Unitb001UsuarioExists(long id)
        {
            return db.Unitb001Usuario.Any(e => e.CoPessoa == id);
        }
    }
}