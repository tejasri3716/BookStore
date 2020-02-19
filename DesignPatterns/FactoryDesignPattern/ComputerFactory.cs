using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.FactoryDesignPattern
{
    class ComputerFactory
    {
        public static Computer GetComputerObject(String typeOfObj)
        {
            Computer obj = null;
            if(typeOfObj.ToLower()=="pc")
            {
                obj = new PC("2GB","500GB","2.4GHz");
            }
            else
            {
                obj = new Server("16GB", "1TB", "2.9GHz");
            }
            return obj;
        }
    }
}
