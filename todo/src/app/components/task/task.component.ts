import { Component, Input } from '@angular/core';
import { Todo } from '../../models/todo-model';

@Component({
  selector: 'app-task',
  templateUrl: './task.component.html',
  styleUrls: ['./task.component.scss']
})
export class TaskComponent {
  constructor() { }
  @Input() task: Todo = { id: 0, name: ''};


 
} 
