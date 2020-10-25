using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    /*
        En esta clase alicamos SRP, ConsolePrinter tiene la responsabilidad de
        imprimir una receta por consola, esto permite extraer la responsabilidad
        que estaba en la clase Recipe y mejorar la cohesion entre los modulos de nuestro
        programa
    */
    public class ConsolePrinter
    {
        public void Print(Recipe recipe)
        {
            Console.WriteLine(recipe.Print());            
        }
    }
}