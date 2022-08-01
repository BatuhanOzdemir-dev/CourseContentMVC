using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzaDelivery.Models;

namespace RazorPizzaDelivery.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel(){
                ImageTitle = "Margarita", 
                PizzaName = "Margarita", 
                BasePrice = 2, 
                TomatoSauce = true, 
                Cheese = true, 
                FinalPrice = 4},
            new PizzasModel(){
                ImageTitle = "Pepperoni",
                PizzaName = "Pepperoni",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Peperoni = true,                
                FinalPrice = 5},
            new PizzasModel(){
                ImageTitle = "Mushroom",
                PizzaName = "Mushroom",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Mushroom = true,                
                FinalPrice = 5},
            new PizzasModel(){
                ImageTitle = "Seafood",
                PizzaName = "Seafood",
                BasePrice = 2,
                Ham = true,
                Tuna = true,
                FinalPrice = 4}
        };
        public void OnGet()
        {
        }
    }
}
