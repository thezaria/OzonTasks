using System;
using System.Collections.Generic;

namespace OzonTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Good> goods = new List<Good>();
            goods.Add(new Good("test good1", 1.5, DateTime.Now.AddDays(-10)));
            goods.Add(new Good("test good2", 15.7, DateTime.Now.AddDays(-5)));
            goods.Add(new Good("test good3", 10.5, DateTime.Now.AddDays(-7)));
            goods.Add(new Good("test good4", 1.5, DateTime.Now.AddDays(-5)));

           // Console.WriteLine($"Good name = {GetGood(goods).Name}");

            Console.WriteLine($"Good1 = Good4: {goods[0].Equals(goods[3])} ");
        }

        public static Good GetGood(List<Good> goods)
        {
            goods.Sort((x, y) => x.Price.CompareTo(y.Price));
            if (goods.Count > 1)
            {
                if (goods[0].Price.Equals(goods[1].Price))
                {
                    goods.FindAll(x => x.Price.Equals(goods[0].Price)).Sort((x, y) => x.CreatedDate.CompareTo(y.CreatedDate));
                }
            }
            //  goods.Sort((x, y) => x.CreatedDate.CompareTo(y.CreatedDate));
            return goods[0];
        }
    }
}
