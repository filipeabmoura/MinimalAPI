namespace ToDo
{
    using Microsoft.EntityFrameworkCore;

    class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options)
            : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();

        public DbSet<Usuario> Usuarios => Set<Usuario>();
    }
}
