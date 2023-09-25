using System;

namespace PracticasParaEstructurada.Clases
{
    public class Metodos
    {
        public int SumaRecursiva(int numeroIngresado, int contador, int resultadoSuma)
        {
            if (numeroIngresado < 0)
            {
                return resultadoSuma;
            }
            else if(numeroIngresado == contador)
            {
                return resultadoSuma;
            }
            else
            {
                contador++;
                resultadoSuma += contador;
                return SumaRecursiva(numeroIngresado, contador, resultadoSuma);
            }
        }
    }
    public class Persona
    {
        public int edad { get; set; }
        public string nombrePersona { get; set; }
        public string resultado { get; set; }

        public string DatosPerosna(int edad, string nombrePersona)
        {
            resultado = $"{nombrePersona}, con edad de {edad}";
            return resultado;
        }

    }
}
