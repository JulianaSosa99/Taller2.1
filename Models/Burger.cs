using System.ComponentModel.DataAnnotations;

namespace Juliana_Sosa_Taller1.Models
{
    public class Burger

    {
        public int BurgerID { get; set; }
        [Required]
        public string? Name { get; set; }
        public bool WithCheese {  get; set; }
        [Range(0.01, 9999.9)] //el rango del siguiente atributo
        public decimal Precio { get; set; }
        //hola es una clase nueva

    }
}
