using System;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Xml;

namespace ThinkLikeAProg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeX();
            ShapeHourGlass();
            //ShapeCircle();
            //Draw();
            TerjeRev();
            //NewLine();

            //Shape1Square();
            //Shape2Triangle();
            //Shape3TriangleRev();
            //Shape1Square();

            //NewLine();
            //NewLine();

            Shape4SidewaysTri();

            //DrawShape2_1();
        }

        // ########
        //  ###### 
        //   ####  
        //    ##   

        //#        #
        // ##    ##
        //  ######

        //  ######
        // ##    ##
        //#        #
        public static void ShapeX()
        {
            for (int row = 0; row < 3; row++)
            {
                Console.WriteLine();
                Space(row);
                HashTag(1 + 1 * row);
                Space(8 - 4 * row);
                HashTag(1 + 1 * row);
            }
            for (int row = 0; row < 3; row++)
            {
                Console.WriteLine();
                Space(2 - 1 * row);
                HashTag(3 - 1 * row);
                Space(4 * row);
                HashTag(3 - 1 * row);
            }
        }

        public static void ShapeHourGlass()
        {
            for (int row = 0; row < 4; row++)
            {
                NewLine(); 
                Space(1 * row);
                HashTag(8 - 2 * row);
            }
            for (int row = 0; row < 4; row++)
            {
                NewLine();
                Space(3 - 1 * row);
                HashTag(2 + 2 * row);
            }
        }

        public static void ShapeCircle()
        {
            for (int row = 0; row < 4; row++)
            {
                NewLine();
                Space( 1 * row);
                HashTag(1 + 1 * row);
            }
        }
        public static void HashTag(int count)
        {
            for (int i = 0; i < count; i++)
            { HashTag(); }
        }
        public static void Space(int count)
        {
            for (int i = 0; i < count; i++)
            { Space(); }
        }
        public static void HashTag()
        { Console.Write("#"); }

        public static void Space()
        { Console.Write("-"); }
        public static void NewLine()
        { Console.WriteLine(); }

        public static void TerjeRev()
        {
            Console.WriteLine("Terje");
            string[] s = { "T", "E", "R", "J", "E" };
            Array.Reverse(s);
            for (int i = 0; i < s.Length; i++) 
                Console.Write(s[3]);
        }
        public static void Shape1Square()
        {
            string[] s = { "   #####", "   #####", "   #####", "   #####" };
            for (int i = 0; i < s.Length; i++) 
                Console.WriteLine(s[i]);
        }
        public static void Shape2Triangle()
        {
            string[] s = { "  #######", "   ##### ", "    ###  ", "     #   " };
            for (int i = 0; i < s.Length; i++) 
                Console.WriteLine(s[i]);
        }
        public static void Shape3TriangleRev()
        {
            string[] s = { "  #######", "   ##### ", "    ###  ", "     #   " };
            Array.Reverse(s);
            for (int i = 0; i < s.Length; i++) 
                Console.WriteLine(s[i]);
        }

        public static void Shape4SidewaysTri()
        {
            for (int row = 1; row < 5; row++)
            {
                NewLine();
                HashTag(1+1 *row);
            }
            for (int row = 1; row < 3; row++)
            {
                NewLine();
                HashTag(4-1 * row);
            }
        }


        public static void DrawShape2_1()
        {
            for (int i = 0; i < 9; i++)
            {
                Space();
                HashTag(8 - 1 * i );
                Space();
            }
        }

        public void DrawShape2_2()
        {
            
        }

       
    }
}
