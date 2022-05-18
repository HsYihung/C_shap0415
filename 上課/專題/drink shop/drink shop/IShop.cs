using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drink_shop
{
    interface IShop
    {
        int shopNum { get; set; }
        //string shopName { get; set; }

        Dictionary<string, int> drink { get; set; }
        Dictionary<string, int> feed { get; set; }
    }
}
