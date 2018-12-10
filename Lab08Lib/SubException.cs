using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab08Lib
{
    public class SubException : Exception
    {
        public SubException(string message) : base(message) { }
    }
    public class InvalidCostException : Exception
    {
        public InvalidCostException() : base("Неверная стоимость тарифа услуг") { }
    }
    
}
