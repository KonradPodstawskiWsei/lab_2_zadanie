using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_zadanie {
    class Seller : Person {
        public Seller(string name, int age) : base(name, age) {
            Name = name;
            Age = age;
        }

        public override void Print(string prefix) {
            Console.WriteLine(prefix + "Seller's name: " + Name + "; Seller's age:" + Age);
        }
    }
}
