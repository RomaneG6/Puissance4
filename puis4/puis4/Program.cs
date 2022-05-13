using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace puis4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matP = new int[6, 7];
            int[,] matP2 = new int[6, 7];
			//commentaire
            LectureTab(ref matP);
            Console.ReadLine();
            JeuxTab(ref matP);
        }

        static void LectureTab(ref int[,] matP)
        {
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(matP[i, j]);
                }
                Console.WriteLine();
            }
            int c = int.Parse(Console.ReadLine());
            Console.WriteLine($"Encoder la ligne oùvous voulez placer votre pièce");
            Console.ReadLine();
        }
        
        static void JeuxTab(ref int[,] matP2)
        {
            for (int i = 0; i < 6; i++)
            {
                for ( int j = 0; j < 7; j++)
                {
                    Console.WriteLine(matP2[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
        