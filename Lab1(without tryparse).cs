using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            double length;
            double width;
            double area;
            double perimeter;
            string check_cont ="Y";
            

            while (check_cont == "Y")
             
           { 

                Console.WriteLine("Enter value of length :");
                length = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter value of width :");
                width = Convert.ToDouble(Console.ReadLine());

                area = (length * width);
                perimeter = 2 * (length + width);

                Console.WriteLine("Area of the room : " + area);
                Console.WriteLine("Perimeter of the room : " + perimeter);
               

                Console.WriteLine("Please enter Y to continue :");
                check_cont = Console.ReadLine();
            }

            
        }
                    

           

        }

     }
        
    


