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

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}");
            }
            //Se agrega al final de la impresion el costo total de producción.
            Console.WriteLine("Costo total de produccion: " + this.TotalCostRecipe());
            
        }
        /// <summary>
        /// Al ser Recipe el experto en la informacion del total de la receta le corresponde a el sumar el
        /// total de costos.
        /// </summary>
        public double TotalCostRecipe()
        {
            double sum = 0;
            foreach (Step steps1 in this.steps){
                sum = sum + steps1.TotalCost();
            }
            return sum;
        }
    }
}