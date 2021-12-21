using Microsoft.EntityFrameworkCore;

namespace Ag_Auto_Estima.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set;}
        public DbSet<Reserva> Reservas { get; set;}

    }


    
       

    }

