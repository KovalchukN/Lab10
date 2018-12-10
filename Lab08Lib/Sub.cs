using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08Lib
{
    public class Sub
    {
        public string Name { get; set; }
        public string SecondName { get; set; }
        public string PhoneNum { get; set; }
        public string Country { get; set; }
        private int cost;
        public int Cost
        {
            get
            { return cost; }
            set
            {
                if (value > 1 &&value < 300)
                {
                    cost = value;
                }
                else
                {
                    throw new InvalidCostException();
                }
            }
        }
        public bool HasCost { get; set; }
       
        public Sub()
        {

        }
        public Sub(string name, string secondName, string phoneNum, string country, int cost, bool hasCost)
        {
            Name = name;
            SecondName = secondName;
            PhoneNum = phoneNum;
            Country = country;
            Cost = cost;
            HasCost = hasCost;
        }

    }
}
