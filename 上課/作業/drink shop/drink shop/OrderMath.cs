using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drink_shop
{
    class OrderMath
    {
        double _totOrderPrice = 0.0;
        int _OrderDPrice = 0;
        int _OrderQuantity = 0;
        public int shopNum = 0;
        List<int> discountTemp = new List<int>();
        List<int> discount = new List<int>();

        public double totOrderPrice
        {
            get
            {
                return _totOrderPrice;
            }
            set
            {

            }
        }
        public double orderPrice(int myPrice,int myQuantity )
        {
            double mytotal = 0.0;
            mytotal = myPrice * myQuantity;
            _OrderQuantity = myQuantity;
            _OrderDPrice = myPrice;
            _totOrderPrice += mytotal;
            discountAdd();
            return mytotal;
        }
        void discountAdd()
        {
            for(int i= 0;i < _OrderQuantity;i++)
            {
                discountTemp.Add(_OrderDPrice);
            }
            discount.AddRange(discountTemp);
            discountTemp.Clear();
            discount.Sort();
            _OrderDPrice = 0;
            _OrderQuantity = 0;
        }
        public void reOrder(int myDPrice,int myQuantity)
        {
            _totOrderPrice -= (myDPrice * myQuantity);
            _OrderDPrice = myDPrice;
            _OrderQuantity = myQuantity;
            discountRemove();
        }
        void discountRemove()
        {
            for(int i = 0;i < _OrderQuantity ;i++)
            {
                discount.RemoveAt(_OrderDPrice);
            }
            _OrderDPrice = 0;
            _OrderQuantity = 0;
        }


    }
}
