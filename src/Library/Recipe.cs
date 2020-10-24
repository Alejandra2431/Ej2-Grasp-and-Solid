//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public string Print()
        {
            /* Expert: se cumple el patron expert ya que Recipe es experto en la informacion de los steps, para implementar el
            metodo print para devover un string con todos los datos de la receta.
            SRP: se mantiene el SRP ya que la unica razon de cambio de Recipe es devolver la informacion de la receta en forma de string.
             */
            string result = $"Receta de {this.FinalProduct.Description}:\n";
            foreach (Step step in this.steps)
            {
                result = result + $"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}" + "\n";
            }

            return result;
        }
    }
}