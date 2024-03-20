import { Injectable } from '@angular/core';
import { Todo } from '../models/todo-model';
import { HttpClient } from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class TodoService {

  constructor(public http: HttpClient) { }

  getTodos() {
    return this.http.get('http://localhost:7176/api/todo');
  }
  addTodos(todo:Todo) {
    return this.http.post('http://localhost:7176/api/todo', todo);
  }
  deleteTodos(id:number){
    return this.http.delete('http://localhost:7176/todos/'+id);
  }
  updateTodos(todo:Todo){
    return this.http.put('http://localhost:7176/todos', todo);
  }
  
}
