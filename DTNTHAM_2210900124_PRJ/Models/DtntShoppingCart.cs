using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DTNTHAM_2210900124_PRJ.Models
{
    public class DtntShoppingCart
    {
        public List<DtntCartItem> Items { get; set; } = new List<DtntCartItem>();

        public void AddItem(int productId, int quantity)
        {
            var existingItem = Items.Find(item => item.ProductId == productId);
            if (existingItem != null)
            {
                existingItem.Quantity += quantity;
            }
            else
            {
                Items.Add(new DtntCartItem { ProductId = productId, Quantity = quantity });
            }
        }

        public void RemoveItem(int productId)
        {
            Items.RemoveAll(item => item.ProductId == productId);
        }

        public decimal TotalPrice(List<DtntProduct> products)
        {
            decimal total = 0;
            foreach (var item in Items)
            {
                var product = products.Find(p => p.Id == item.ProductId);
                if (product != null)
                {
                    total += product.Price * item.Quantity;
                }
            }
            return total;
        }
    }
}