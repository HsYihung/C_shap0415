using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drink_shop
{
    class shop3 : IShop
    {
        static string _shopName = "鮮茶道";
        int _shopNum = 103;

        Dictionary<string, int> _drink = new Dictionary<string, int>()
        {
            {"四季春",35 },
            {"蜜香紅茶",35 },
            {"蜜香果茶",35 },
            {"玉露煎茶",35 },
            {"阿里山里佳甘露",45 },
            {"阿里山冰茶",55 },
            {"頂級茉莉綠茶",55 },
            {"琥珀紅茶",55 },
            {"古香烏龍",55 },
            {"紅茶拿鐵",60 },
            {"綠茶拿鐵",60 },
            {"伯爵拿鐵",60 }
        };
        Dictionary<string, int> _feed = new Dictionary<string, int>()
        {
            {"熊貓珍珠",10 },
            {"QQ",10 },
            {"布丁",15 },
            {"奶蓋",15 }
        };
        public static string shopName
        {
            get
            {
                return _shopName;
            }
            set
            {

            }
        }
        public int shopNum
        {
            get
            {
                return _shopNum;
            }
            set
            {

            }
        }
        public Dictionary<string, int> drink { get { return _drink; } set { } }
        public Dictionary<string, int> feed { get { return _feed; } set { } }
    }
}
