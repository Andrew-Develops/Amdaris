using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class BuildShape
    {
        public Shape CreateShape(string text)
        {
            if (text == null)
            {
                return null;
            }
            if (text.ToUpper().Equals("CIRCLE"))
            {
                return new Circle();
            }
            else if (text.ToUpper().Equals("RECTANGLE"))
            {
                return new Rectangle();
            }
            else if (text.ToUpper().Equals("SQUARE"))
            {
                return new Square();
            }
            return null;

        }
    }
}
