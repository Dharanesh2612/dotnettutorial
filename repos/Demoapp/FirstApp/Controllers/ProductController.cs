using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Product product = new Product();
            product.Product_Name = "Dharan";
            product.Product_Prize = 10000;
            product.Product_Disc = 21;
            return View(product);
        }
       
    }
}
