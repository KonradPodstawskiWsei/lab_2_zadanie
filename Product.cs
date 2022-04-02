using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_zadanie {
    class Product : IThing {
        private string name;

        public string Name {
            get => name;
            set { name = value; }
        }

        public Product(string name) {
            Name = name;
        }

        public virtual void Print(string prefix) {
            Console.WriteLine(prefix + "Product's name: " + Name);
        }
    }

}
