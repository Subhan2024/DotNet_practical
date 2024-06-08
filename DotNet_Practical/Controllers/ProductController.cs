using DotNet_Practical.Models;
using Microsoft.AspNetCore.Mvc;

namespace DotNet_Practical.Controllers
{
    public class ProductController : Controller
    {
        private readonly AddToCartContext _context;

        public ProductController(AddToCartContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            ViewBag.products = from product in _context.Products
                               join order in _context.Orders on product.Id equals order.ProductId
                               select new
                               {
                                   prodName = product.Name,
                                   prodPrice = product.Description,
                                   prodDesc = product.Price,
                                   Quantity = product.Quantity,
                                   productid = order.ProductId,
                                   Card_Id = order.CartId,
                                   order_Quantity = order.Quantity
                               };
            return View();
        }
    }
}
