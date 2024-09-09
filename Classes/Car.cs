using System;
using System.Collections.Generic;
using System.Globalization;
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
        //below are backing fields for their respective properties ie _model is a backing field for modem
        //backing fields can be omitte when ther's no value to be gotten or set
        //the value of _model is not alterd at any point(not MANUALLY gotten or set), so it can function without a backing field
        /*private string _model = "";*/
        //the above can be subtitued with public string Model {  get; set; }
        private string _brand = "";
        //the same applies for _is luxury
        /*private bool _isLuxury;*/

        // this is a constructor, it's called when an object of that class is created
        // in the parentheses of a public constructor is ment for passing data that will serve as the paremiter

        //this two sets of code are, sorrounding properties, they allow _model to be indirectly accessed via the public string, "Model" and also prevent direct access to "_model"


        //this is a lambda expression
        //public bool IsLuxury { get => _isLuxury; set => _isLuxury = value; }
        public bool IsLuxury{ get; set; }
        //it does the same thing as 

        /*
        public bool isLuxury
        {
            get
            {
                return _isLuxury;
            }
            set
            {
                _isLuxury = value;
            }
        }
        */
        /*public string Model { get => _model; set => _model = value; }*/
        public string Model {  get; set; }

        public string Brand {/*getting brand*/ 
            get
            {
                if (IsLuxury)
                {
                    return _brand + " -Luxury Eddition";
                }
                else
                {
                    return _brand;
                }
            }
            
            set 
            
            {

                //put a break point at the if statement to see the "value" in action
                //brand setiing 
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine("You've entered nothing!");
                    _brand = "Brand is DEFAULTVALUE";
                }else 
                {
                    _brand = value; 
                }

            }
                
                
                }

        

        //this a custom constructor
        public Car(string brand,string model, bool isluxury) 
        {
            Brand = brand;
            Model = model;
            IsLuxury = isluxury; 
            Console.WriteLine($"A {brand} car of model {model} was created ");
        }
    }
}
