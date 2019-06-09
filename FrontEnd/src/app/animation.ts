import {
  transition,
  trigger,
  query,
  style,
  animate,
  group,
  animateChild
} from '@angular/animations';

export const slideInAnimation =
  trigger('routeAnimations', [
    transition('* => *', [
      query(':enter, :leave',
        style({position: 'fixed'}), {optional: true}),
      group([
        query(':enter', [
          style({transform: 'translateY(100%)', width: '100%'}),
          animate('0.3s ease-in-out',
            style({transform: 'translateY(0%)', width: '100%'}))
        ], {optional: true}),
        query(':leave', [
          style({transform: 'translateY(0%)', width: '100%'}),
          animate('0.3s ease-in-out',
            style({transform: 'translateY(-100%)', width: '100%'}))
        ], {optional: true}),
      ])
    ])
  ]);
