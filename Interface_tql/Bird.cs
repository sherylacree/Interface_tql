using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_tql;
internal class Bird : IPet {

// What Properties for Birds, Color, Type, Can Fly, 
public string Color {  get; set; } = string.Empty;
  public string Type { get; set; } = string.Empty;        
public bool CanFly {  get; set; }
public string Speak() {
    return "Tweet";
}
}