using EfCoreCrud.Data;
using EfCoreCrud.Models;

using var context = new MyDataContext();

//CREATE:
var todo1 = new Todo(1,"Ir ao supermercado");
var todo2 = new Todo(2,"Ir a academia");
var todo3 = new Todo(3,"Levar o carro na oficina");

context.Todos.Add(todo1);
context.Todos.Add(todo2);
context.Todos.Add(todo3);
context.SaveChanges();

//READ:
var todos = context.Todos.ToList();
Console.WriteLine("\nPrintando todos os itens no banco:\n");
foreach(var item in todos)
{  
    Console.WriteLine(item.Title);
}

//UPDATE:
var todoToUpdate = context.Todos.FirstOrDefault(x => x.Id == 2);
todoToUpdate.Title = "ALTERADO!";
context.Todos.Update(todoToUpdate);
context.SaveChanges();

//DELETE:
Console.WriteLine("\nExcluindo o item 3\n");
var todoToDelete = context.Todos.FirstOrDefault( x => x.Id == 3 );
context.Todos.Remove(todoToDelete);
context.SaveChanges();

Console.WriteLine("\nPrintando os itens novamente:\n");
foreach(var item in context.Todos.ToList())
{  
    Console.WriteLine($"Id: {item.Id}, Title: {item.Title}");
}

// FirstOrDefault. -> Caso o item não exista ele retorna null.
// SingleOrDefault. -> Caso tenha mais de um ele vai retornar um Erro.
// Single().
