﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WingtipToys.Models
{
    public class ProductDatabaseInitializer :
        DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }
        private static List<Category> GetCategories()
        {
            {
                var Categories = new List<Category>{
                
                new Category
                {
                    CategoryID=1,
                    CategoryName = "Cars"

                },
                new Category
                {
                    CategoryID=2,
                    CategoryName="Planes"
                
                },
                new Category
                {
                    CategoryID = 3,
                    CategoryName = "Trucks"

                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Boats"

                },
                new Category
                {
                   CategoryID = 5,
                   CategoryName = "Rockets"
                },
                };
                return Categories;
            }
        }
        private static List<Products> GetProducts()
        {
            var Products = new List<Products>{
                new Products
                {
                    ProductsID=1,
                    ProductName="Convertible Car",
                    Description="This convertible car is fast! The engine is powered by a neutrino based battery (not included)." + "Power it up and let it go!",
                    ImagePath="Convertible Car",
                    UnitPrice=22.50,
                    CategoryID=1,
                },
                new Products
                {
                    ProductsID=2,
                    ProductName="Old-time Car",
                    Description="There's nothing old about this toy car, except it's looks. Compatible with other old toy cars.",
                    ImagePath="Carearly.png",
                    UnitPrice=15.95,
                    CategoryID=1
                },
                new Products
                {
                    ProductsID=3,
                    ProductName="Fast Car",
                    Description="Yes this car is fast, but it also floats in water.",
                    ImagePath="CarFast.png",
                    UnitPrice=32.99,
                    CategoryID=1
                    
                },
                new Products
                {
                    ProductsID=4,
                    ProductName="Super Fast Car",
                    Description="Use this super fast car to entertain guests. Lights and doors work!",
                    ImagePath="CarFaster.png",
                    UnitPrice=8.95,
                    CategoryID=1
                },
                new Products { ProductsID = 5, ProductName = "Old Style Racer", Description = "This old style racer can fly (with user assistance). Gravity controls flight duration." + "No batteries required.", ImagePath="carracer.png", UnitPrice = 34.95, CategoryID = 1 },
        new Products { ProductsID = 6, ProductName = "Ace Plane", Description = "Authentic airplane toy. Features realistic color and details.", ImagePath="planeace.png", UnitPrice = 95.00, CategoryID = 2 },
        
        new Products { ProductsID = 7, ProductName = "Glider", Description = "This fun glider is made from real balsa wood. Some assembly required.", ImagePath="planeglider.png", UnitPrice = 4.95, CategoryID = 2 }, 
            
        new Products { ProductsID = 8, ProductName = "Paper Plane", Description = "This paper plane is like no other paper plane. Some folding required.", ImagePath="planepaper.png", UnitPrice = 2.95, CategoryID = 2 },

        new Products { ProductsID = 9, ProductName = "Propeller Plane", Description = "Rubber band powered plane features two wheels.", ImagePath="planeprop.png", UnitPrice = 32.95, CategoryID = 2 },
        new Products { ProductsID = 10, ProductName = "Early Truck", Description = "This toy truck has a real gas powered engine. Requires regular tune ups.", ImagePath="truckearly.png", UnitPrice = 15.00, CategoryID = 3 },
        new Products {
ProductsID = 11, ProductName = "Fire Truck", Description = "You will have endless fun with this one quarter sized fire truck.", ImagePath="truckfire.png", UnitPrice = 26.00, CategoryID = 3 },
   new Products { ProductsID = 12, ProductName = "Big Truck", Description = "This fun toy truck can be used to tow other trucks that are not as big.", ImagePath="truckbig.png", UnitPrice = 29.00, CategoryID = 3 },     
    new Products { ProductsID = 13, ProductName = "Big Ship", Description = "Is it a boat or a ship. Let this floating vehicle decide by using its " + "artifically intelligent computer brain!", ImagePath="boatbig.png", UnitPrice = 95.00, CategoryID = 4 },
           new Products { ProductsID = 14, ProductName = "Paper Boat", Description = "Floating fun for all! This toy boat can be assembled in seconds. Floats for minutes!" + "Some folding required.", ImagePath="boatpaper.png", UnitPrice = 4.95, CategoryID = 4 },
           new Products { ProductsID = 15, ProductName = "Sail Boat", Description = "Put this fun toy sail boat in the water and let it go!", ImagePath="boatsail.png", UnitPrice = 42.95, CategoryID = 4 },
           new Products { ProductsID = 16, ProductName = "Rocket", Description = "This fun rocket will travel up to a height of 200 feet.", ImagePath="rocket.png", UnitPrice = 122.95, CategoryID = 5 
           } 
            };
            return Products;
        }
    };
}
       
            

                     