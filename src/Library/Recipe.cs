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

        private ConsolePrinter console = new ConsolePrinter();
        public Product FinalProduct { get; set; }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public void PrintRecipe()
        {
            /* Creator: se uso el patron creator dado que el objeto ConsolePrinter se crea en la clase Recipe y tiene una
            relacion muy estrecha con dicha clase.
            SRP: para mantener el srp, se creo una nueva clase ConsolePrinter, pasandole la responsabilidad de imprimir por consola
            a dicha clase. De esa forma Recipe solo tiene la responsabilidad de agregar o quitar steps de su lista.
            */
            this.console.Print(steps, FinalProduct);
        }
    }
}