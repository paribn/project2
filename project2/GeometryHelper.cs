using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace project2
{
    static class GeometryHelper
    {
         public static void CalculateAngle()
        {

            try
            {
                Console.WriteLine("wide: ");
                double wide = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("length");
                double length = Convert.ToDouble(Console.ReadLine());   
                double Area = wide * length;
                Console.WriteLine("Area is :" + Area);
            }
            catch (Exception ex)
            {

                //throw new ArgumentOutOfRangeException();
                Console.WriteLine(ex.Message);
            }
        }
         public static  void CalculateAngle1()
        {
            try
            {
                Console.WriteLine("Enter Radius :");
                double Radius = Convert.ToDouble(Console.ReadLine());
                double Area = Math.PI * Radius * Radius;
                Console.WriteLine("Area is :" + Area);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        } 
        public static void CalculateAngle2()
        {
            try
            {
                Console.WriteLine("Write base:");
                double Base = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Heigth :");
                double Height = Convert.ToDouble(Console.ReadLine());
                double Area = (Base * Height) / 2;
                Console.WriteLine("Area is :" + Area);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
           

        }
       
        
    }
}
