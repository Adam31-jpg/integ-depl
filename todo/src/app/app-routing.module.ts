import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TodoHomeComponent } from './components/todo-home/todo-home.component';

const routes: Routes = [
  { path: '', component: TodoHomeComponent, pathMatch: 'full' }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
