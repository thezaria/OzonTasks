using System;
namespace OzonTask2
{
    public class Good
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public DateTime CreatedDate { get; set; }

        public Good()
        {
        }

        public Good (string name, double price, DateTime date)
        {
            Name = name;
            Price = price;
            CreatedDate = date;
        }

        public override bool Equals(object obj)
        {
            if (obj is Good )
            {
                if (this.Price == (obj as Good).Price)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
