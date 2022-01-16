using System;
using System.Text;



class Line
{
   public static void PrintLine(int length)
   {
            var output = new StringBuilder();
            for (int i = 0; i < length; i++){
                output.Append("_");
            }
            Console.Write($"{output} \n");
   }
}