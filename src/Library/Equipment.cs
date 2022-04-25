//-------------------------------------------------------------------------------
// <copyright file="Equipment.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Equipment
    {
        public Equipment(string description, double hourlyCost)
        {
            this.Description = description;
            this.HourlyCost = hourlyCost;
        }

        public string Description { get; set; }

        public double HourlyCost { get; set; }
        
        /// <summary>
        /// Al ser Equipment el experto en la informacion de equipment le corresponde a el realizar
        /// el costo en horas
        /// </summary>
        /// <param name="minutes"></param>
        /// <returns></returns>
        public double TotalCost(int minutes)
        {
            return this.HourlyCost * minutes / 60;
        }

    }
}