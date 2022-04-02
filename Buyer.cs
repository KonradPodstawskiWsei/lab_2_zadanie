using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_zadanie {
    class Buyer : Person {
        protected List<Product> tasks = new List<Product>();

        public Buyer(string name, int age):base(name,age) {
            Name = name;
            Age = age;
        }


        public void AddProduct(Product product) {
            tasks.Add(product);
        }

        public void RemoveProduct(int index) {
            tasks.RemoveAt(index);
        }

        public override void Print(string prefix) {
            string productList = "";
            Console.WriteLine(prefix + "Buyer's name: " + Name + "; Buyer's age:" + Age + "\n" + productList);
            foreach (Product p in tasks) {
                p.Print("\t \t");
            }

        }
    }
}
