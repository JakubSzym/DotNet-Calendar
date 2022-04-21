using Microsoft.Extensions.Configuration;
using System.Data.Entity;



namespace Calendar
{   
    /**
    * @class ApplicationDbContext Klasa która zawiera kontekst utworzonej bazy danych. 
    * Dziedziczy ona po klasie DbConetxt z Entity Framweorka.
    **/
    public class ApplicationDbContext : DbContext
    {   
        /**
        * @var Tasks Zawiera listę obiektów klasy Task. 
        **/
        public DbSet<Task>? Tasks { get; set; }

        public ApplicationDbContext() : base()
        {

        }
    }
}
