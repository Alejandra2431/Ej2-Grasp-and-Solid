using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter
    {
        public void Print(ArrayList steps,Product finalProduct)
        {
            Console.WriteLine($"Receta de {finalProduct.Description}:");
            foreach (Step step in steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
        }
    }
}