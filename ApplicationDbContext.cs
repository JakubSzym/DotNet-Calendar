using Microsoft.Extensions.Configuration;
using System.Data.Entity;



namespace Calendar
{   
    /**
    * Klasa która zawiera kontekst utworzonej bazy danych. Dziedziczy ona po klasie DbConetxt z Entity Framweorka.
    **/
    public class ApplicationDbContext : DbContext
    {   
        /**
        * Zawiera listę obiektów klasy Task. 
        **/
        public DbSet<Task>? Tasks { get; set; }

        public ApplicationDbContext() : base()
        {

        }
    }
}
