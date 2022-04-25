//--------------------------------------------------------------------------------------
// <copyright file="Product.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//---------------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Product
    {
        public Product(string description, double unitCost)
        {
            this.Description = description;
            this.UnitCost = unitCost;
        }

        public string Description { get; set; }

        public double UnitCost { get; set; }
        /// <summary>
        /// Al ser Product el experto en la informacion de los productos de la receta le corresponde a el realizar
        /// el costo por cantidad del producto. Cumpliendo asi el patron expert..
        /// </summary>
        public double TotalCost(double quantity)
        {
            return this.UnitCost * quantity;
        }
    }
}