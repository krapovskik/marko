using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezhba2
{
    public class ProductQuantity
    {
        public Product product { get; set; }
        public decimal quantity { get; set; }

        public ProductQuantity(Product product, decimal quantity)
        {
            this.product = product;
            this.quantity = quantity;
        }

        public decimal totalPrice()
        {
            return this.product.Price * this.quantity;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} x {2} = {3}",this.product.Name,this.quantity,this.product.Price, totalPrice());
        }
    }
}
