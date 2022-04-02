using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_zadanie {
    class Shop : IThing {
        private string name;
        public string Name { get => name; set { name = value; } }
        private Person[] people;
        private Product[] products;

        public Shop(string name, Person[] people, Product[] products) {
            Name = name;
            this.people = people;
            this.products = products;
        }

        public void Print() {
            Console.WriteLine("Shop: " + Name);
            Console.WriteLine("-- People: --");
            foreach (Person p in people)
            {
                p.Print("\t");
            }
            Console.WriteLine("-- Products: --");
            foreach (Product p in products)
            {
                p.Print("\t");
            }
        }
    }
}
