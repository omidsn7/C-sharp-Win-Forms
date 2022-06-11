using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class ShoppingCartModel
    {
        public delegate void ManageSum(Decimal sumTotal);

        public List<ProductModel> Items { get; set; } = new List<ProductModel>();

        public decimal GenerateTotal(ManageSum manageSum,
            Func<List<ProductModel>, decimal, decimal> calculatediscountTotal,
            Action<string> TelluserApplyingdiscount)
        {
            decimal subTotal = Items.Sum(x => x.Price);

            manageSum(subTotal);

            TelluserApplyingdiscount("We Are Applying Your Discount");

            return calculatediscountTotal(Items, subTotal);
        }
    }
}
