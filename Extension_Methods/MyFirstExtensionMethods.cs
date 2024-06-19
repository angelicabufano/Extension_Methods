using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Extension_Methods;
public static class MyFirstExtensionMethods {                  // change "internal" to "public" , make class static by putting "static" infront of class

    public static void Debug(this string str, string label) {    // put void so that it doesnt have to return anything , always put "this" then type, then name
        Console.WriteLine($"{label}: [{str}]");
       
    }

    public static void Debug(this int i, string label) {
        Console.WriteLine($"{label}: [{i}]");
    }
    
    public static int Cubed(this int i) {
        return i * i * i;
    }

    public static int Funct(this int x) {
        return (x * x) + (x * 3) + 5;
    }
}
