using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_tql;
internal class Cat : IPet{

//What properties of cat to add, Weight, Age, Color, Speak
public int Weight { get; set; }
public int Age {  get; set; }
public string Color {  get; set; } = string.Empty;  
    public string Speak() {
        return "Meow!";
}
}