using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PersonInfo<T>
    {
        public T data;

        
        public void saveDate(T inputData)
        {
            data = inputData;
            switch (Type.GetTypeCode(typeof(T)))
            {
                case TypeCode.String:
                    Console.WriteLine("string 型態");
                    break;
                case TypeCode.Int32:
                    Console.WriteLine("int 型態");
                    break;
                case TypeCode.Double:
                    Console.WriteLine("Double 型態");
                    break;
                case TypeCode.Boolean:
                    Console.WriteLine("bool 型態");
                    break;
                default:
                    Console.WriteLine("其他資料型態");
                    break;
            }
        }

        public T dataGetSet
        {

            get
            {
                return data;
            }
            set
            {
                data = value;
                Console.WriteLine($"{Type.GetTypeCode(typeof(T))}");
            }
        }
    }
}
