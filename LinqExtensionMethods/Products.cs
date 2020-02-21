using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExtensionMethods {
    
        public class Product {

        public string Code { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public bool Taxible { get; set; }

        public object ProductCode { get; internal set; }
    }
}


