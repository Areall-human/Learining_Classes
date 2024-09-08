using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Car
        //This class is intenal, it can only be accesed within this assembley(file), class
    {
        //member variables is a variable inside a class but outside of any method
        //this is a constructor, it is similar to a method, it's nameed the same as the class, it's placed, it has no retun, and it's always executed once an objecct of class is createed
        //it's format is "private" then "var type" then and _ before (no spaces) "var name" then "=" then "var value" and finallly ";"
        //"private hides the variable from other classes like the program class"
        private string _model = "";
        private string _brand = "";
        
        // this is a constructor, it's called when an object of that class is created
        // in the parentheses of a public constructor is ment for passing data that will serve as the paremiter
        public Car(string brand,string model) 
        {
            _brand = brand;
            _model = model;
            Console.WriteLine($"A {brand} car of model {model} was created ");
        }
    }
}
