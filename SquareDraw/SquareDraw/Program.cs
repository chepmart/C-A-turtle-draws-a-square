using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SmallBasic.Library;


namespace SquareDraw
{
    class Program
    {
        static void Main(string[] args)
        {
            var len = 75;
            Turtle.Speed = 5;

            Square(len);

        }

        private static void Square(int len)
        {
            for(int i=0; i<10; i++)
            {
                Turtle.Move(len);
                Turtle.Turn(90);
                Turtle.Move(len);
                Turtle.Turn(90);
                Turtle.Move(len);
                Turtle.Turn(90);
                Turtle.Move(len);
            }

           
       
        }
    }
}
