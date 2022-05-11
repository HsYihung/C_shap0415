using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drink_shop
{
    class shop1 : IShop
    {
        static string _shopName = "五十嵐";
        public int _shopNum = 101;
        Dictionary<string, int> _drink = new Dictionary<string, int>()
        {
            {"茉莉綠茶", 25 },
            {"阿薩姆紅茶", 25 },
            {"四季春茶",25 },
            {"檸檬綠",50 },
            {"多多綠",50 },
            {"奶茶",50 },
            {"奶綠",50 },
            {"黑糖奶茶",55 },
            {"焦糖奶茶",55 },
            {"綠茶拿鐵",55 },
            {"烏龍拿鐵",55 },
            {"阿華田拿鐵",65 }
        };

        Dictionary<string, int> _feed = new Dictionary<string, int>()
        {
            {"珍珠",10 },
            {"波霸",10 },
            {"芋圓",15 },
            {"布丁",20 },            
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
