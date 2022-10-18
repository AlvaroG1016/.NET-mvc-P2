namespace Punto2Quiz.Models
{

    public class Calculo
    {

         public const double metNorte = 80000;
         public const double porcNorte = 96000;



        public object Data(Persona ola) //Método que realiza el calculo si llegó al tope o no, recibiendo un objeto del tipo persona
        {
            if (ola.ubi == "Norte" && ola.ventas >= metNorte && ola.ventas <= porcNorte) //hago los porcentajes y la validación
            {
                ola.Total = ola.ventas + (ola.ventas * 0.5); //Si entra, se le aplica su bonificación del 0.5
                ola.Bonif = "Obtuvo una bonificación del 0.5%, superó la meta del 100% (80.000)";

            } else if (ola.ventas > porcNorte && ola.ubi=="Norte") //If anidado no funcionó, tuve que poner else if para hacer la validacion de más del 120%
            {
                ola.Total = ola.ventas + (ola.ventas * 0.10);
                ola.Bonif = "Obtuvo una bonificación del 0.10%, superó la meta del 120% (96.000)";

            }
            else if (ola.ventas <  metNorte && ola.ubi == "Norte")
            {
                ola.Mensaje = "No cumplío la meta";
                ola.Total = ola.ventas;
            }

            if (ola.ubi == "Centro" && ola.ventas >= 120000 && ola.ventas<= 144000)
            {
                ola.Total = ola.ventas + (ola.ventas * 0.5); //Si entra, se le aplica su bonificación
                ola.Bonif = "Obtuvo una bonificación del 0.5%, superó la meta del 100% (120.000)";

            }
            else if (ola.ventas > 144000 && ola.ubi=="Centro")
            {
                ola.Total = ola.ventas + (ola.ventas * 0.10);
                ola.Bonif = "Obtuvo una bonificación del 0.10%´, superó la meta del 120% (144.000)";


            }
            else if (ola.ventas < 120000 && ola.ubi == "Centro")
            {
                ola.Mensaje = "No cumplío la meta";
                ola.Total = ola.ventas;
            }

            if (ola.ubi == "Sur" && ola.ventas >= 5000 && ola.ventas <= 6000)
            {
                ola.Total = ola.ventas + (ola.ventas * 0.5); //Si entra, se le aplica su bonificación
                ola.Bonif = "Obtuvo una bonificación del 0.5%, superó la meta del 100% (5.000)";

            }
            else if (ola.ventas > 6000 && ola.ubi == "Sur")
            {
                ola.Total = ola.ventas + (ola.ventas * 0.10);
                ola.Bonif = "Obtuvo una bonificación del 0.10%, superó la meta del 120% (6.000)";


            }
            else if (ola.ventas < 5000 && ola.ubi == "Sur")
            {
                ola.Mensaje = "No cumplío la meta";
                ola.Total = ola.ventas;
            }
            if (ola.ubi == "Occidente" && ola.ventas >= 3000 && ola.ventas <= 3600)
            {
                ola.Total = ola.ventas + (ola.ventas * 0.5); //Si entra, se le aplica su bonificación
                ola.Bonif = "Obtuvo una bonificación del 0.5%, superó la meta del 100% (3.000)";

            }
            else if (ola.ventas > 3600 && ola.ubi == "Occidente")
            {
                ola.Total = ola.ventas + (ola.ventas * 0.10);
                ola.Bonif = "Obtuvo una bonificación del 0.10%, superó la meta del 120% (3.600)";

            }
            else if (ola.ventas < 3000 && ola.ubi == "Occidente")
            {
                ola.Mensaje = "No cumplío la meta";
                ola.Total = ola.ventas;
            }
            if (ola.ubi == "Oriente" && ola.ventas >= 4000 && ola.ventas <= 4800)
            {
                ola.Total = ola.ventas + (ola.ventas * 0.5); //Si entra, se le aplica su bonificación
                ola.Bonif = "Obtuvo una bonificación del 0.5%, superó la meta del 100% (4.000)";

            }
            else if (ola.ventas > 4800 && ola.ubi == "Oriente")
            {
                ola.Total = ola.ventas + (ola.ventas * 0.10);
                ola.Bonif = "Obtuvo una bonificación del 0.10%, superó la meta del 120% (4.800)";


            }
            else if (ola.ventas < 4000 && ola.ubi == "Oriente")
            {
                ola.Mensaje = "No cumplío la meta";
                ola.Total = ola.ventas;
            }

            return ola;
        }
    }
}
