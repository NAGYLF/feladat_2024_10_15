using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Targy
    {
        [Key]
        public Guid Azon { get; set; }
        public int Jegy { get; set; }
        public string Leiras { get; set; }
        public DateTime Letrehozas_ideje { get; set; }
    }
}
