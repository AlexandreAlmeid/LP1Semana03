using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            float[,] A = new float[2,2];
            float[] B = new float[2];
            float[] X = new float[2];

            if (args.Length == 6)
            {
                A[0,0] = float.Parse(args[0]);
                A[0,1] = float.Parse(args[1]);
                A[1,0] = float.Parse(args[2]);
                A[1,1] = float.Parse(args[3]);

                B[0] = float.Parse(args[4]);
                B[1] = float.Parse(args[5]);
                X[0] = 0.0f;
                X[1] = 0.0f;

                for(int i = 0; i < 2; i++)
                {
                    for(int j = 0; j < 2; j++)
                    {
                        X[i] += A[i,j] * B[j];
                    }
                }
                Console.WriteLine(X[0]);
                Console.WriteLine(X[1]);
            } 
        }
    }
}
