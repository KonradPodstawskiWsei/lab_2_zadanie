using System;
using System.Collections.Generic;
using System.Text;

namespace lab_2_zadanie {
    class Person : IThing {
        private string name;

        public string Name {
            get => name;
            set { name = value; }
        }

        private int age;

        public int Age {
            get => age;
            set { age = value; }
        }

        public Person(string name, int age) {
            Name = name;
            Age = age;
        }

        public virtual void Print (string prefix) {
            Console.WriteLine(prefix + "Person's name: " + Name + "; Person's age:" + Age);
        }
    }
}
