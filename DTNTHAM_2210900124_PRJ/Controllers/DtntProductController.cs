using DTNTHAM_2210900124_PRJ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DTNTHAM_2210900124_PRJ.Controllers
{
    public class DtntProductController : Controller
    {
        private static List<DtntProduct> Dtntproducts = new List<DtntProduct>
        {
            new DtntProduct { Id = 1, Name = "Sản phẩm 1", Price = 100000, ImageUrl = "~/Content/images/product1.jpg" },
            new DtntProduct { Id = 2, Name = "Sản phẩm 2", Price = 200000, ImageUrl = "~/Content/images/product2.jpg" }
        };

        public ActionResult Index()
        {
            return View(Dtntproducts);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(DtntProduct dtntproduct)
        {
            if (ModelState.IsValid)
            {
                dtntproduct.Id = Dtntproducts.Count + 1; // Tạo ID mới
                Dtntproducts.Add(dtntproduct);
                return RedirectToAction("Index");
            }
            return View(dtntproduct);
        }

        public ActionResult Edit(int id)
        {
            var dtntproduct = Dtntproducts.FirstOrDefault(p => p.Id == id);
            return View(dtntproduct);
        }

        [HttpPost]
        public ActionResult Edit(DtntProduct dtntproduct)
        {
            if (ModelState.IsValid)
            {
                var existingProduct = Dtntproducts.FirstOrDefault(p => p.Id == dtntproduct.Id);
                if (existingProduct != null)
                {
                    existingProduct.Name = dtntproduct.Name;
                    existingProduct.Price = dtntproduct.Price;
                    existingProduct.ImageUrl = dtntproduct.ImageUrl;
                }
                return RedirectToAction("Index");
            }
            return View(dtntproduct);
        }

        public ActionResult Delete(int id)
        {
            var dtntproduct = Dtntproducts.FirstOrDefault(p => p.Id == id);
            return View(dtntproduct);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var dtntproduct = Dtntproducts.FirstOrDefault(p => p.Id == id);
            if (dtntproduct != null)
            {
                Dtntproducts.Remove(dtntproduct);
            }
            return RedirectToAction("Index");
        }

        public ActionResult AddToCart(int productId, int quantity)
        {
            // Thêm sản phẩm vào giỏ hàng
            DtntShoppingCart cart = (DtntShoppingCart)Session["Cart"] ?? new DtntShoppingCart();
            cart.AddItem(productId, quantity);
            Session["Cart"] = cart;
            return RedirectToAction("Index");
        }

        private class DtntShoppingCart
        {
            internal void AddItem(int productId, int quantity)
            {
                throw new NotImplementedException();
            }
        }
    }
}