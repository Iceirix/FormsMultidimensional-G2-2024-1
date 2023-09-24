using System;

namespace FormsMultidimensional_G2_2024_1
{
    internal class Multidimensional: Matriz
    {
        float[,] A;

        public Multidimensional(int M, int N)
        {
            this.M = M;
            this.N = N;
            A = new float[this.M, this.N];
        }

        public static Multidimensional Leer(string A)
        {
            // Matriz A ingresada
            // 1,2;3,4 Matriz ingresada Ejemplo
            string[] renglones = A.Split (';') ;

            // renglones[0] = 1,2
            // renglones[1] = 3,4
            string[] columnas = renglones[0].Split(',');

            Multidimensional m1 = new Multidimensional(renglones.Length, columnas.Length);
            
            for(int i = 0; i < m1.M; i++)
            {
                columnas = renglones[i].Split(',');
                for (int j = 0; j < m1.N; j++)
                {
                    m1.A[i, j] = float.Parse(columnas[j]);
                }
            }


            return m1;
        }
        public override string ToString()
        {
            //1  2
            //3  4
            string A = "";
            for (int i = 0; i < M; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    A += " " + this.A[i, j].ToString();
                }
                A += "\n";
            }
            return A;
        }

    }
}
