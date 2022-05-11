using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drink_shop
{
    class shop2 : IShop
    {
        static string _shopName = "麻古茶坊";
        int _shopNum = 102;
        Dictionary<string, int> _drink = new Dictionary<string, int>()
        {
            {"高山金萱茶",45 },
            {"芝芝金萱",50 },
            {"芝芝翡翠綠茶",50 },
            {"翡翠綠茶",50 },
            {"梅子冰茶",50 },
            {"梅子綠茶",50 },
            {"錫蘭奶茶",50 },
            {"冰翠檸檬",55 },
            {"玫瑰奶茶",60 },
            {"阿華田",60 },
            {"芝芝錫蘭奶茶",65 },
            {"芝芝錫蘭紅茶",65 }
        };


        Dictionary<string, int> _feed = new Dictionary<string, int>()
        {
            {"椰果",5 },
            {"珍珠",10 },
            {"布丁",15 },
            {"冰淇淋",20 }
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
