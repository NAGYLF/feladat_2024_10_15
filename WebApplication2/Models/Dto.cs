namespace WebApplication2.Models
{
    public class Dto
    {
        public record CreateTargyDto(int Jegy, string Leiras,DateTime Letrohazs_ideje);
        public record UpdateTargyDto(int Jegy, string Leiras, DateTime Letrohazs_ideje);
    }
}
