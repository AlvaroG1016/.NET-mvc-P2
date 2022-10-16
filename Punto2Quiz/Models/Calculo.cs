namespace Punto2Quiz.Models
{
    public class Calculo
    {
        public object Data(Persona ola)
        {
            if (ola.ubi == "Norte" && ola.ventas >= 80800 && ola.ventas <= 96000) //hago los porcentajes y la validación
            {
                ola.Total = ola.ventas + (ola.ventas * 0.5); //Si entra, se le aplica su bonificación

            } else if (ola.ventas > 96000 && ola.ubi=="Norte") //If anidado no funcionó, tuve que poner else if para hacer la validacion de más del 120%
            {
                    ola.Total = ola.ventas + (ola.ventas * 0.10);
            }else if (ola.ventas <  80000 && ola.ubi == "Norte")
            {
                ola.Mensaje = "No cumplío la meta";
                ola.Total = ola.ventas;
            }

                if (ola.ubi == "Centro" && ola.ventas >= 120000 && ola.ventas<= 144000)
            {
                ola.Total = ola.ventas + (ola.ventas * 0.5); //Si entra, se le aplica su bonificación
         
            }else if (ola.ventas > 144000 && ola.ubi=="Centro")
            {
                ola.Total = ola.ventas + (ola.ventas * 0.10);

            }
            else if (ola.ventas < 120000 && ola.ubi == "Centro")
            {
                ola.Mensaje = "No cumplío la meta";
                ola.Total = ola.ventas;
            }

            if (ola.ubi == "Sur" && ola.ventas >= 5000 && ola.ventas <= 6000)
            {
                ola.Total = ola.ventas + (ola.ventas * 0.5); //Si entra, se le aplica su bonificación

            }
            else if (ola.ventas > 6000 && ola.ubi == "Sur")
            {
                ola.Total = ola.ventas + (ola.ventas * 0.10);

            }
            else if (ola.ventas < 5000 && ola.ubi == "Sur")
            {
                ola.Mensaje = "No cumplío la meta";
                ola.Total = ola.ventas;
            }
            if (ola.ubi == "Occidente" && ola.ventas >= 3000 && ola.ventas <= 3600)
            {
                ola.Total = ola.ventas + (ola.ventas * 0.5); //Si entra, se le aplica su bonificación

            }
            else if (ola.ventas > 3600 && ola.ubi == "Occidente")
            {
                ola.Total = ola.ventas + (ola.ventas * 0.10);

            }
            else if (ola.ventas < 3000 && ola.ubi == "Occidente")
            {
                ola.Mensaje = "No cumplío la meta";
                ola.Total = ola.ventas;
            }
            if (ola.ubi == "Oriente" && ola.ventas >= 4000 && ola.ventas <= 4800)
            {
                ola.Total = ola.ventas + (ola.ventas * 0.5); //Si entra, se le aplica su bonificación

            }
            else if (ola.ventas > 4800 && ola.ubi == "Oriente")
            {
                ola.Total = ola.ventas + (ola.ventas * 0.10);

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
