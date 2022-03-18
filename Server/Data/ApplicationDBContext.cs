using Formular1.Shared;
using Microsoft.EntityFrameworkCore;

namespace Formular1.Server.Data
{
    public class ApplicationDBContext:DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)
        {

        }
        public DbSet<Teilnehmer> Teilnehmers { get; set; }
        public DbSet<HotelZimmer> HotelZimmers { get; set; }
        public DbSet<TeilnehmerPVLive> TeilnehmerPVLives { get; set; }
    }
}
