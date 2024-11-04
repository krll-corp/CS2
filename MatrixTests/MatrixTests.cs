using NUnit.Framework;
namespace MatrixApp.Tests
{
    [TestFixture]
    public class MatrixTests
    {
        [Test]
        public void Addition_Positive()
        {
            Matrix matrix1 = new Matrix(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Matrix matrix2 = new Matrix(9, 8, 7, 6, 5, 4, 3, 2, 1);
            Matrix sum = matrix1.Add(matrix2);

            Assert.AreEqual(10, sum.GetElement(0, 0));
            Assert.AreEqual(10, sum.GetElement(0, 1));
            Assert.AreEqual(10, sum.GetElement(0, 2));
            Assert.AreEqual(10, sum.GetElement(1, 0));
            Assert.AreEqual(10, sum.GetElement(1, 1));
            Assert.AreEqual(10, sum.GetElement(1, 2));
            Assert.AreEqual(10, sum.GetElement(2, 0));
            Assert.AreEqual(10, sum.GetElement(2, 1));
            Assert.AreEqual(10, sum.GetElement(2, 2));
        }

        [Test]
        public void Multiplication_Positive()
        {
            Matrix matrix = new Matrix(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Matrix result = matrix.Multiply(2);

            Assert.AreEqual(2, result.GetElement(0, 0));
            Assert.AreEqual(4, result.GetElement(0, 1));
            Assert.AreEqual(6, result.GetElement(0, 2));
            Assert.AreEqual(8, result.GetElement(1, 0));
            Assert.AreEqual(10, result.GetElement(1, 1));
            Assert.AreEqual(12, result.GetElement(1, 2));
            Assert.AreEqual(14, result.GetElement(2, 0));
            Assert.AreEqual(16, result.GetElement(2, 1));
            Assert.AreEqual(18, result.GetElement(2, 2));
        }

        [Test]
        public void Multiplication_Negative()
        {
            Matrix matrix = new Matrix(1, -2, 3, -4, 5, -6, 7, -8, 9);
            Matrix result = matrix.Multiply(-3);

            Assert.AreEqual(-3, result.GetElement(0, 0));
            Assert.AreEqual(6, result.GetElement(0, 1));
            Assert.AreEqual(-9, result.GetElement(0, 2));
            Assert.AreEqual(12, result.GetElement(1, 0));
            Assert.AreEqual(-15, result.GetElement(1, 1));
            Assert.AreEqual(18, result.GetElement(1, 2));
            Assert.AreEqual(-21, result.GetElement(2, 0));
            Assert.AreEqual(24, result.GetElement(2, 1));
            Assert.AreEqual(-27, result.GetElement(2, 2));
        }

        [Test]
        public void Determinant()
        {
            Matrix matrix = new Matrix(2, 0, 1, 3, 0, 0, 5, 1, 1);
            int det = matrix.Determinant();

            Assert.AreEqual(3, det);
        }

        [Test]
        public void Transpose()
        {
            Matrix matrix = new Matrix(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Matrix transposed = matrix.Transpose();

            Assert.AreEqual(1, transposed.GetElement(0, 0));
            Assert.AreEqual(4, transposed.GetElement(0, 1));
            Assert.AreEqual(7, transposed.GetElement(0, 2));
            Assert.AreEqual(2, transposed.GetElement(1, 0));
            Assert.AreEqual(5, transposed.GetElement(1, 1));
            Assert.AreEqual(8, transposed.GetElement(1, 2));
            Assert.AreEqual(3, transposed.GetElement(2, 0));
            Assert.AreEqual(6, transposed.GetElement(2, 1));
            Assert.AreEqual(9, transposed.GetElement(2, 2));
        }

        [Test]
        public void Addition_Negative()
        {
            Matrix matrix1 = new Matrix(-1, -2, -3, -4, -5, -6, -7, -8, -9);
            Matrix matrix2 = new Matrix(-9, -8, -7, -6, -5, -4, -3, -2, -1);
            Matrix sum = matrix1.Add(matrix2);

            Assert.AreEqual(-10, sum.GetElement(0, 0));
            Assert.AreEqual(-10, sum.GetElement(0, 1));
            Assert.AreEqual(-10, sum.GetElement(0, 2));
            Assert.AreEqual(-10, sum.GetElement(1, 0));
            Assert.AreEqual(-10, sum.GetElement(1, 1));
            Assert.AreEqual(-10, sum.GetElement(1, 2));
            Assert.AreEqual(-10, sum.GetElement(2, 0));
            Assert.AreEqual(-10, sum.GetElement(2, 1));
            Assert.AreEqual(-10, sum.GetElement(2, 2));
        }

        [Test]
        public void Multiplication_Zero()
        {
            Matrix matrix = new Matrix(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Matrix result = matrix.Multiply(0);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreEqual(0, result.GetElement(i, j));
                }
            }
        }

        [Test]
        public void Determinant_ZeroMatrix()
        {
            Matrix matrix = new Matrix(0, 0, 0, 0, 0, 0, 0, 0, 0);
            int det = matrix.Determinant();

            Assert.AreEqual(0, det);
        }

        [Test]
        public void Transpose_ZeroMatrix()
        {
            Matrix matrix = new Matrix(0, 0, 0, 0, 0, 0, 0, 0, 0);
            Matrix transposed = matrix.Transpose();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreEqual(0, transposed.GetElement(i, j));
                }
            }
        }

        [Test]
        public void Addition_WithZeroMatrix()
        {
            Matrix matrix1 = new Matrix(1, 2, 3, 4, 5, 6, 7, 8, 9);
            Matrix zeroMatrix = new Matrix(0, 0, 0, 0, 0, 0, 0, 0, 0);
            Matrix sum = matrix1.Add(zeroMatrix);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreEqual(matrix1.GetElement(i, j), sum.GetElement(i, j));
                }
            }
        }

        [Test]
        public void Multiplication_ByOne()
        {
            Matrix matrix = new Matrix(2, 4, 6, 8, 10, 12, 14, 16, 18);
            Matrix result = matrix.Multiply(1);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreEqual(matrix.GetElement(i, j), result.GetElement(i, j));
                }
            }
        }

        [Test]
        public void Init()
        {
            Matrix identityMatrix = new Matrix(1, 0, 0, 0, 1, 0, 0, 0, 1);

            Assert.AreEqual(1, identityMatrix.GetElement(0, 0));
            Assert.AreEqual(0, identityMatrix.GetElement(0, 1));
            Assert.AreEqual(0, identityMatrix.GetElement(0, 2));
            Assert.AreEqual(0, identityMatrix.GetElement(1, 0));
            Assert.AreEqual(1, identityMatrix.GetElement(1, 1));
            Assert.AreEqual(0, identityMatrix.GetElement(1, 2));
            Assert.AreEqual(0, identityMatrix.GetElement(2, 0));
            Assert.AreEqual(0, identityMatrix.GetElement(2, 1));
            Assert.AreEqual(1, identityMatrix.GetElement(2, 2));
            
            
            
            int det = identityMatrix.Determinant();
            Assert.AreEqual(1, det);
            
            Matrix transposed = identityMatrix.Transpose();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreEqual(identityMatrix.GetElement(i, j), transposed.GetElement(i, j));
                }
            }
        }
    }
}
