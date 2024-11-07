using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DTNTHAM_2210900124_PRJ.Controllers
{
    public class DtntShoppingCartController : Controller
    {
        // GET: DtntShoppingCart
        private static DtntShoppingCartController cart = new DtntShoppingCartController();

        public ActionResult Index()
        {
            return View(cart);
        }

        public ActionResult AddToCart(int productId, int quantity)
        {
            cart.AddItem(productId, quantity);
            return RedirectToAction("Index");
        }

        private void AddItem(int productId, int quantity)
        {
            throw new NotImplementedException();
        }

        public ActionResult RemoveFromCart(int productId)
        {
            cart.RemoveItem(productId);
            return RedirectToAction("Index");
        }

        private void RemoveItem(int productId)
        {
            throw new NotImplementedException();
        }
    }
}