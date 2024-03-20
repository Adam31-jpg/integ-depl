import { Component } from '@angular/core';
import { Todo } from 'src/app/models/todo-model';

@Component({
  selector: 'app-todo-home',
  templateUrl: './todo-home.component.html',
  styleUrls: ['./todo-home.component.scss']
})
export class TodoHomeComponent {
  constructor() { }
  tasks: Todo[] = [
    {
      id: 1,
      name: 'Task 1'
    },
    {
      id: 2,
      name: 'Task 2'
    },
    {
      id: 3,
      name: 'Task 3'
    }
  ];
}
