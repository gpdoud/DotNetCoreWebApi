using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCoreWebApi.models
{
    public class TodoContext : DbContext
    {
		// do this for easy dependency injection
		public TodoContext(DbContextOptions<TodoContext> options) : base(options) {

		}

		public DbSet<Todo> Todos { get; set; }
    }
}
