using EfCoreCrud.Models;
using Microsoft.EntityFrameworkCore;

namespace EfCoreCrud.Data;

public class MyDataContext : DbContext
{
    // public MyDataContext(DbContextOptions<MyDataContext> options) : base(options) {}

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.UseInMemoryDatabase("todos");
        // options.LogTo(Console.WriteLine); // Printa o log da consulta (query).
    }

    public DbSet<Todo>? Todos {get; set;}
}