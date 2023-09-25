using System;
using PracticasParaEstructurada.Clases;

namespace PracticasParaEstructurada
{
    public class Program
    {
        static void Main(string[] args)
        { 
            Console.WriteLine("ingresa tu nombre y tu edad: ");
            Persona persona = new Persona();
            persona.nombrePersona = Console.ReadLine();
            persona.edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(persona.DatosPerosna(persona.edad,persona.nombrePersona));
            Console.ReadKey();
        }
    }
}
