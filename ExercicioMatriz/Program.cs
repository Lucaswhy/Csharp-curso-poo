using System;

namespace ExercicioMatriz {
    class Program {
        static void Main(string[] args) {

            string[] pos = Console.ReadLine().Split(' ');

            int pos1 = int.Parse(pos[0]);
            int pos2 = int.Parse(pos[1]);

            int[,] mat = new int[pos1, pos2];

            for (int i =0 ;i < pos1;i++) {

                string[] values = Console.ReadLine().Split(' ');

                for (int j=0; j<pos2;j++) {
                    mat[i, j] = int.Parse(values[j]);
                }

            }

            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < pos1; i++) {

             
                for (int j = 0; j < pos2; j++) {

                    if (mat[i, j] == N) {
                        Console.WriteLine("Position " + i + "," + j);

                        if (j > 0) {
                            Console.Write("Left: " + mat[i, (j-1)] + "\n");
                        }

                        if (j < (pos2 - 1)) {
                            Console.Write("Right: " + mat[i,(j+1)] + "\n");
                        }

                        if (i > 0) {
                            Console.Write("Up:  " + mat[(i-1),j] + "\n");
                        }

                        if (i < (pos1 - 1 )) {
                            Console.Write("Down: " + mat[(i+1),j] + "\n");
                        }
                    }

                }

            }
        }
    }
}
