//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }

        /// <summary>
        /// Al ser Step el experto en la informacion de las etapas de la receta le corresponde a el realizar
        /// el costo por cantidad sumado del costo de Horas de Equipment.
        /// </summary>
        public double TotalCost()
        {
            return this.Quantity + this.Equipment.TotalCost(this.Time);
        }
    }
}