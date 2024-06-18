using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_tql;
internal class Dog : IPet {

    //What do we want to capture about a dog Breed, Age, Weight

    public string Breed { get; set; } = string.Empty;
    public int Age { get; set; }
    public int Weight { get; set; }
    public string Speak() {
        return "Woof";

    }
}