using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_zadanie {
    class Meat : Product {
        private double weight;
        public double Weight {
            get => weight;
            set
            {
                weight = value;
            }
        }

        public Meat(string name, double weight) : base(name) {
            Name = name;
            Weight = weight;
        }

        public override void Print(string prefix) {
            Console.WriteLine(prefix + "Meat's name: " + Name + "; (" + Weight + " kg)");
        }
    }
}
