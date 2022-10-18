using System.Reflection.Metadata;

namespace Punto2Quiz.Models
{
    public class Persona
    {
        public int ventas { get; set; }
        public string ubi { get; set; } 
        public double Total { get; set; }
        public string Mensaje = "Felicidades, cumplió la meta";
        public string Bonif = "No obtuvo bonificación :c";
    }
   
}
