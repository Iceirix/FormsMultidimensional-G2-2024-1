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
        public static Multidimensional operator +(Multidimensional m1, Multidimensional m2)
        {
            Multidimensional m3 = new Multidimensional(m1.M, m1.N);
            for (int i = 0; i < m1.M; i++)
            {
               
                for (int j = 0; j < m1.N; j++)
                {
                    m3.A[i, j] = m1.A[i, j] + m2.A[i, j];
                }
            }
            return m3;
        }
        public static Multidimensional operator -(Multidimensional m1, Multidimensional m2)
        {
            Multidimensional m3 = new Multidimensional(m1.M, m1.N);

            for (int i = 0; i < m1.M; i++)
            {
                for (int j = 0; j < m1.N; j++)
                {
                    m3.A[i, j] = m1.A[i, j] - m2.A[i, j];
                }
            }
            return m3;
        }
        public static Multidimensional operator *(Multidimensional m1, Multidimensional m2)
        {
            Multidimensional m3 = new Multidimensional(m1.M, m2.N);
            if(m1.N == m2.M)
            {
                for (int i = 0; i < m1.M; i++)
                {
                    for (int j = 0; j < m2.N; j++)
                    {
                        m3.A[i, j] = 0;
                        for (int s = 0; s < m1.N; s++)
                        {
                            m3.A[i, j] += m1.A[i, s] * m2.A[s, j];
                        }
                           
                    }
                }
            }
            
            return m3;
        }
        public static Multidimensional senoMatriz(Multidimensional m, bool V)
        {
            Multidimensional mSeno = new Multidimensional(m.M, m.N);

            for (int i = 0; i < m.M; i++)
            {
                for (int j = 0; j < m.N; j++)
                {
                    if (V)
                        mSeno.A[i, j] = Truncar((float)Math.Sin(m.A[i, j]));
                    else
                        mSeno.A[i, j] = Truncar((float)Math.Sin(m.A[i, j]*(Math.PI/180)));
                }
            }
            return mSeno;
        }
        public static float Truncar(float x)
        {
            return (float)Math.Truncate(x*1000)/1000;
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
                    A += "    " + this.A[i, j].ToString();
                }
                A += "\n\n";
            }
            return A;
        }

    }
}
