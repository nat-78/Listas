using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {

        private static readonly string[] colors = { "MAGENTA", "RED", "WHITE", "BLUE", "CYAN" };
        private static readonly string[] removeColors = { "RED", "WHITE", "BLUE" };

        static void Main(string[] args)
        {

            List<string> colors = new List<string>();
            colors.Add("MAGENTA");
            colors.Add("RED");
            colors.Add("WHITE");
            colors.Add("BLUE");
            colors.Add("CYAN");



            List<string> removecolors = new List<string>();
            removecolors.Add("RED");
            removecolors.Add("WHITE");
            removecolors.Add("BLUE");
            foreach (string color in colors)

                Console.WriteLine(color);

            colors.Remove("RED");
            colors.Remove("WHITE");
            colors.Remove("BLUE");



            foreach (string colores in colors)
            
                Console.WriteLine(colores);
            
           






            Console.ReadLine();
        }

        
      

    }

  
   
    }
