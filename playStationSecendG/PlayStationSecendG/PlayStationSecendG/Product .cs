using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayStationSecendG
{
    internal class Product
    {
        public Product(string product_name, int product_cost)
        {
            this.product_name = product_name;
            this.product_cost=product_cost;
        }
        public int product_id;
        public string product_name;
        public int product_cost;
        public int product_num;
        public int product_dis;

    }
}
