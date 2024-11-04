namespace MatrixApp
{
    public class Matrix
    {
        private int[,] elements;

        public Matrix(int a11, int a12, int a13, int a21, int a22, int a23, int a31, int a32, int a33)
        {
            elements = new int[3, 3]
            {
                { a11, a12, a13 },
                { a21, a22, a23 },
                { a31, a32, a33 }
            };
        }

        public Matrix Add(Matrix other)
        {
            Matrix result = new Matrix(
                elements[0, 0] + other.elements[0, 0],
                elements[0, 1] + other.elements[0, 1],
                elements[0, 2] + other.elements[0, 2],
                elements[1, 0] + other.elements[1, 0],
                elements[1, 1] + other.elements[1, 1],
                elements[1, 2] + other.elements[1, 2],
                elements[2, 0] + other.elements[2, 0],
                elements[2, 1] + other.elements[2, 1],
                elements[2, 2] + other.elements[2, 2]
            );
            return result;
        }

        public Matrix Multiply(int scalar)
        {
            Matrix result = new Matrix(
                elements[0, 0] * scalar, elements[0, 1] * scalar, elements[0, 2] * scalar,
                elements[1, 0] * scalar, elements[1, 1] * scalar, elements[1, 2] * scalar,
                elements[2, 0] * scalar, elements[2, 1] * scalar, elements[2, 2] * scalar
            );
            return result;
        }

        public int Determinant()
        {
            return elements[0, 0] * (elements[1, 1] * elements[2, 2] - elements[1, 2] * elements[2, 1])
                   - elements[0, 1] * (elements[1, 0] * elements[2, 2] - elements[1, 2] * elements[2, 0])
                   + elements[0, 2] * (elements[1, 0] * elements[2, 1] - elements[1, 1] * elements[2, 0]);
        }

        public Matrix Transpose()
        {
            Matrix result = new Matrix(
                elements[0, 0], elements[1, 0], elements[2, 0],
                elements[0, 1], elements[1, 1], elements[2, 1],
                elements[0, 2], elements[1, 2], elements[2, 2]
            );
            return result;
        }

        public int GetElement(int row, int col)
        {
            return elements[row, col];
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            return a.Add(b);
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            int[,] resultElements = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    resultElements[i, j] = 0;
                    for (int k = 0; k < 3; k++)
                    {
                        resultElements[i, j] += a.elements[i, k] * b.elements[k, j];
                    }
                }
            }

            return new Matrix(
                resultElements[0, 0],resultElements[0, 1], resultElements[0, 2],
                resultElements[1, 0], resultElements[1, 1], resultElements[1, 2],
                resultElements[2, 0], resultElements[2, 1], resultElements[2, 2]
            );
        }

        public static Matrix operator *(Matrix a, int scalar)
        {
            return a.Multiply(scalar);
        }

        public static Matrix operator *(int scalar, Matrix a)
        {
            return a.Multiply(scalar);
        }

        public static int operator ~(Matrix a)
        {
            return a.Determinant();
        }

        public static Matrix operator !(Matrix a)
        {
            return a.Transpose();
        }
    }
}


namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
