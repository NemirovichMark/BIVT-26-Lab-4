namespace Lab4test
{
    [TestClass]
    public sealed class GreenTest
    {
        Lab4.Green _main = new Lab4.Green();
        const double E = 0.0001;

        [TestMethod]
        public void Test01()
        {
            // Arrange
            var input = new double[][] {
              new double[] {  -2, -1, 0, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, -7, 8, 8, -1, 0, 0, 5, -5, -8, 2, 3 },
              new double[] {  2, 1, 0, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, 7, 8, 8, 1, 0, 0, 5, 5, 8, 2, 3 },
              new double[] {  2, 1, 1, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, 7, 8, 8, 1, 4, 4, 5, 5, 8, 2, 3 },
              new double[] {  -2, -1, -1, -1, -2, -3, -3, -8, -5, -3, -1, -1, -1, -2, -7, -8, -8, -1, -4, -4, -5, -5, -8, -2, -3 },
              new double[] {  -2, -1, 0, -1, -2, -3, -3, -8, -5, -3, -1, -1, -1, -2, -7, -8, -8, -1, 0, 0, -5, -5, -8, -2, -3 },
              new double[] {  0, 0, 0, 0, 0 },
              new double[] {  1, 1, 1 },
              new double[] {  -3, -2, -3, -2 },
              new double[] {  3, 2, 3, 2 },
              new double[] {  3, -2, -3, 2 },
              new double[] {  -2, 88, 5, 3, 1, 1, 15, -8, 2, -33 },
              new double[] {  1, 2, 3, 1, 2, 3, 1, 1, 1, 2, 3, 3, 3 },
              new double[] {  1, -2, -3, -1, 2, 3, 1, 1, -1, -2, -3, 3, 3 },
              new double[] {  0, 8, 15, 15, 15, -15, -15, -8, 2, -3 },
              new double[] {  5 }
            };
            var answer = new double[][] {
              new double[] { -2, -1, 0, 3.5, 3.5, 3.5, 3.5, 3.5, 3.5, 3.5, 3.5, 3.5, 3.5, 3.5, -7, 3.5, 3.5, -1, 0, 0, 3.5, -5, -8, 3.5, 3.5 },
              new double[] { 3.6363636363636362, 3.6363636363636362, 0, 3.6363636363636362, 3.6363636363636362, 3.6363636363636362, 3.6363636363636362, 3.6363636363636362, 3.6363636363636362, 3.6363636363636362, 3.6363636363636362, 3.6363636363636362, 3.6363636363636362, 3.6363636363636362, 3.6363636363636362, 3.6363636363636362, 3.6363636363636362, 3.6363636363636362, 0, 0, 3.6363636363636362, 3.6363636363636362, 3.6363636363636362, 3.6363636363636362, 3.6363636363636362 },
              new double[] { 3.56, 3.56, 3.56, 3.56, 3.56, 3.56, 3.56, 3.56, 3.56, 3.56, 3.56, 3.56, 3.56, 3.56, 3.56, 3.56, 3.56, 3.56, 3.56, 3.56, 3.56, 3.56, 3.56, 3.56, 3.56 },
              new double[] { -2, -1, -1, -1, -2, -3, -3, -8, -5, -3, -1, -1, -1, -2, -7, -8, -8, -1, -4, -4, -5, -5, -8, -2, -3 },
              new double[] { -2, -1, 0, -1, -2, -3, -3, -8, -5, -3, -1, -1, -1, -2, -7, -8, -8, -1, 0, 0, -5, -5, -8, -2, -3 },
              new double[] { 0, 0, 0, 0, 0 },
              new double[] { 1, 1, 1 },
              new double[] { -3, -2, -3, -2 },
              new double[] { 2.5, 2.5, 2.5, 2.5 },
              new double[] { 2.5, -2, -3, 2.5 },
              new double[] { -2, 16.428571428571427, 16.428571428571427, 16.428571428571427, 16.428571428571427, 16.428571428571427, 16.428571428571427, -8, 16.428571428571427, -33 },
              new double[] { 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2, 2 },
              new double[] { 2, -2, -3, -1, 2, 2, 2, 2, -1, -2, -3, 2, 2 },
              new double[] { 0, 11, 11, 11, 11, -15, -15, -8, 11, -3 },
              new double[] { 5 }
            };
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                _main.Task1(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i].Length, input[i].Length);
                for (int j = 0; j < answer[i].Length; j++)
                {
                    Assert.AreEqual(answer[i][j], input[i][j], E, $"Test {i} failed (index {j})");
                }
            }
        }
        [TestMethod]
        public void Test02()
        {
            // Arrange
            var input = new int[][] {
              new int[] { -2, -1, 0, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, -7, 8, 8, -1, 0, 0, 5, -5, -8, 2, 3 },
              new int[] { 2, 1, 0, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, 7, 8, 8, 1, 0, 0, 5, 5, 8, 2, 3 },
              new int[] { 2, 1, 1, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, 7, 8, 8, 1, 4, 4, 5, 5, 8, 2, 3 },
              new int[] { 2, 1, 1, 1, 2, 3, -3, -1, -1, -2, -7, -8, -8, -1, -4, -4, -5, -5, -8, -2, -3 },
              new int[] { 2, 3, -3, 8, -5, 3, -1, -1, 1, -2, -7, -8, -8, 1, 0, 0, -5, -5, -8, -2, -3 },
              new int[] { 0, 0, 0, 0, 0 },
              new int[] { 1, 1, 1 },
              new int[] { -3, -2, -3, -2 },
              new int[] { 3, 2, 3, 2 },
              new int[] { 3, -2, -3, 2 },
              new int[] { 2, 88, 5, 3, 1, 1, 15, -8, 2, -33 },
              new int[] { 1, 2, 3, 1, 2, 3, 1, 1, 1, 2, 3, 3, 3 },
              new int[] { 1, 2, 3, -1, 2, 3, 1, 1, -1, -2, -3, 3, 3 },
              new int[] { 0, 8, 15, 15, 15, -15, -15, -8, 2, -3 },
              new int[] { 5 }
            };
            var answer = new int[] { 0, 0, 0, 20, 13, 0, 0, 0, 0, 9, 8009, 0, 14, 739, 0 };
            var test = new int[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task2(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i], $"Test {i} failed");
            }
        }
        [TestMethod]
        public void Test03()
        {
            // Arrange
            var input = new int[][] {
                new int[] { -2, -1, 0, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, -7, 8, 8, -1, 0, 0, 5, -5, -8, 2, 3 },
                new int[] { 2, 1, 0, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, 7, 8, 8, 1, 0, 0, 5, 5, 8, 2, 3 },
                new int[] { 2, 1, 1, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, 7, 8, 8, 1, 4, 4, 5, 5, 8, 2, 3 },
                new int[] { 2, 1, 1, -1, -2, -3, -3, -8, -5, -3, -1, -1, 1, 2, 7, -8, -8, -1, -4, -4, -5, -5, 8, 2, 3 },
                new int[] { -2, -1, 0, -1, -2, -3, -3, -8, -5, -3, -1, -1, -1, -2, -7, -8, -8, -1, 0, 0, -5, -5, -8, -2, -3 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] {  1, -1, 1 },
                new int[] { -3, -2, -3, -2 },
                new int[] { 3, 2, 3, 2 },
                new int[] { 3, -2, -3, 2 },
                new int[] { -2, 88, 5, 3, 1, 1, 15, -8, 2, -33 },
                new int[] { 1, 2, 3, 1, 2, 3, 1, 1, 1, 2, 3, 3, 3 },
                new int[] { 1, -2, -3, -1, 2, 3, 1, 1, -1, -2, -3, 3, 3 },
                new int[] { 0, 8, 15, 15, 15, -15, -15, -8, 2, -3 },
                new int[] { 5 }
            };
            var answer = new int[][] {
                new int[] { -7, -1, -5 },
                new int[] {  },
                new int[] {  },
                new int[] { -5, -3, -1, -1, -8, -8, -1, -4, -4, -5, -5 },
                new int[] { -1, -2, -3, -3 },
                new int[] {  },
                new int[] {  },
                new int[] {  },
                new int[] {  },
                new int[] { -2 },
                new int[] { -8 },
                new int[] {  },
                new int[] { -1 },
                new int[] {  },
                new int[] {  }
            };
            var test = new int[answer.Length][];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task3(input[i]);
            }
            // Assert
            Assert.AreNotEqual(input, test);
            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == null)
                {
                    Assert.IsNull(test[i]);
                    continue;
                }
                Assert.AreEqual(answer[i].Length, test[i].Length);
                for (int j = 0; j < answer[i].Length; j++)
                {
                    Assert.AreEqual(answer[i][j], test[i][j], $"Test {i} failed (index {j})");
                }
            }
        }
        [TestMethod]
        public void Test04()
        {
            // Arrange
            var input = new int[][] {
              new int[] { -2, -1, 0, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, -7, 8, 8, -1, 0, 0, 5, -5, -8, 2, 3 },
              new int[] { 2, 1, 0, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, 7, 8, 8, 1, 0, 0, 5, 5, 8, 2, 3 },
              new int[] { 2, 1, 1, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, 7, 8, 8, 1, 4, 4, 5, 5, 8, 2, 3 },
              new int[] { -2, -1, -1, -1, -2, -3, -3, -8, -5, -3, -1, -1, -1, -2, -7, -8, -8, -1, -4, -4, -5, -5, -8, -2, -3 },
              new int[] { -2, -1, 0, -1, -2, -3, -3, -8, -5, -3, -1, -1, -1, -2, -7, -8, -8, -1, 0, 0, -5, -5, -8, -2, -3 },
              new int[] { 0, 0, 0, 0, 0 },
              new int[] { 1, 1, 1 },
              new int[] { -3, -2, -3, -2 },
              new int[] { 3, 2, 3, 2 },
              new int[] { 3, -2, -3, 2 },
              new int[] { -2, 88, 5, 3, 1, 1, 15, -8, 2, -33 },
              new int[] { 1, 2, 3, 1, 2, 3, 1, 1, 1, 2, 3, 3, 3 },
              new int[] { 1, -2, -3, -1, 2, 3, 1, 1, -1, -2, -3, 3, 3 },
              new int[] { 0, 8, 15, 15, 15, -15, -15, -8, 2, -3 },
              new int[] { 5 }
            };
            var answer = new int[][] {
              new int[] { 8, -1, 0, 1, 2, 3, 3, -2, 5, 3, 1, 1, 1, 2, -7, 8, 8, -1, 0, 0, 5, -5, -8, 2, 3 },
              new int[] { 2, 1, 0, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, 7, 8, 8, 1, 0, 0, 5, 5, 8, 2, 3 },
              new int[] { 2, 1, 1, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, 7, 8, 8, 1, 4, 4, 5, 5, 8, 2, 3 },
              new int[] { -1, -2, -1, -1, -2, -3, -3, -8, -5, -3, -1, -1, -1, -2, -7, -8, -8, -1, -4, -4, -5, -5, -8, -2, -3 },
              new int[] { 0, -1, -2, -1, -2, -3, -3, -8, -5, -3, -1, -1, -1, -2, -7, -8, -8, -1, 0, 0, -5, -5, -8, -2, -3 },
              new int[] { 0, 0, 0, 0, 0 },
              new int[] { 1, 1, 1 },
              new int[] { -2, -3, -3, -2 },
              new int[] { 3, 2, 3, 2 },
              new int[] { -2, 3, -3, 2 },
              new int[] { 88, -2, 5, 3, 1, 1, 15, -8, 2, -33 },
              new int[] { 1, 2, 3, 1, 2, 3, 1, 1, 1, 2, 3, 3, 3 },
              new int[] { 1, 3, -3, -1, 2, -2, 1, 1, -1, -2, -3, 3, 3 },
              new int[] { 0, 8, -15, 15, 15, 15, -15, -8, 2, -3 },
              new int[] { 5 }
            };
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                _main.Task4(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == null)
                {
                    Assert.IsNull(input[i]);
                    continue;
                }
                Assert.AreEqual(answer[i].Length, input[i].Length);
                for (int j = 0; j < answer[i].Length; j++)
                {
                    Assert.AreEqual(answer[i][j], input[i][j], $"Test {i} failed (index {j})");
                }
            }
        }
        [TestMethod]
        public void Test05()
        {
            // Arrange
            var input = new int[][] {
              new int[] { -2, -1, 0, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, -7, 8, 8, -1, 0, 0, 5, -5, -8, 2, 3 },
              new int[] { 2, 1, 0, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, 7, 8, 8, 1, 0, 0, 5, 5, 8, 2, 3 },
              new int[] { 2, 1, 1, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, 7, 8, 8, 1, 4, 4, 5, 5, 8, 2, 3 },
              new int[] { -2, -1, -1, -1, -2, -3, -3, -8, -5, -3, -1, -1, -1, -2, -7, -8, -8, -1, -4, -4, -5, -5, -8, -2, -3 },
              new int[] { -2, -1, 0, -1, -2, -3, -3, -8, -5, -3, -1, -1, -1, -2, -7, -8, -8, -1, 0, 0, -5, -5, -8, -2, -3 },
              new int[] { 0, 0, 0, 0, 0 },
              new int[] { 1, 1, 1 },
              new int[] { -3, -2, -3, -2 },
              new int[] { 3, 2, 3, 2 },
              new int[] { 3, -2, -3, 2 },
              new int[] { -2, 88, 5, 3, 1, 1, 15, -8, 2, -33 },
              new int[] { 1, 2, 3, 1, 2, 3, 1, 1, 1, 2, 3, 3, 3 },
              new int[] { 1, -2, -3, -1, 2, 3, 1, 1, -1, -2, -3, 3, 3 },
              new int[] { 0, 8, 15, 15, 15, -15, -15, -8, 2, -3 },
              new int[] { 5 }
            };
            var answer = new int[][] {
              new int[] { 7, 15, 16 },
              new int[] { 7, 15, 16, 22 },
              new int[] { 7, 15, 16, 22 },
              new int[] { 1, 2, 3, 10, 11, 12, 17 },
              new int[] { 2, 18, 19 },
              new int[] { 0, 1, 2, 3, 4 },
              new int[] { 0, 1, 2 },
              new int[] { 1, 3 },
              new int[] { 0, 2 },
              new int[] { 0 },
              new int[] { 1 },
              new int[] { 2, 5, 10, 11, 12 },
              new int[] { 5, 11, 12 },
              new int[] { 2, 3, 4 },
              new int[] { 0 }
            };
            var test = new int[answer.Length][];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task5(input[i]);
            }
            // Assert
            Assert.AreNotEqual(input, test);
            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == null)
                {
                    Assert.IsNull(test[i]);
                    continue;
                }
                Assert.AreEqual(answer[i].Length, test[i].Length);
                for (int j = 0; j < answer[i].Length; j++)
                {
                    Assert.AreEqual(answer[i][j], test[i][j], $"Test {i} failed (index {j})");
                }
            }
        }
        [TestMethod]
        public void Test06()
        {
            // Arrange
            var input = new int[][] {
              new int[] { -2, -1, 0, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, -7, 8, 8, -1, 0, 0, 5, -5, -8, 2, 3 },
              new int[] { 2, 1, 0, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, 7, 8, 8, 1, 0, 0, 5, 5, 8, 2, 3 },
              new int[] { 2, 1, 1, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, 7, 8, 8, 1, 4, 4, 5, 5, 8, 2, 3 },
              new int[] { -2, -1, -1, -1, -2, -3, -3, -8, -5, -3, -1, -1, -1, -2, -7, -8, -8, -1, -4, -4, -5, -5, -8, -2, -3 },
              new int[] { -2, -1, 0, -1, -2, -3, -3, -8, -5, -3, -1, -1, -1, -2, -7, -8, -8, -1, 0, 0, -5, -5, -8, -2, -3 },
              new int[] { 0, 0, 0, 0, 0 },
              new int[] { 1, 1, 1 },
              new int[] { -3, -2, -3, -2 },
              new int[] { 3, 2, 3, 2 },
              new int[] { 3, -2, -3, 2 },
              new int[] { -2, 88, 5, 3, 1, 1, 15, -8, 2, -33 },
              new int[] { 1, 2, 3, 1, 2, 3, 1, 1, 1, 2, 3, 3, 3 },
              new int[] { 1, -2, -3, -1, 2, 3, 1, 1, -1, -2, -3, 3, 3 },
              new int[] { 0, 8, 15, 15, 15, -15, -15, -8, 2, -3 },
              new int[] { 5 }
            };
            var answer = new int[][] {
              new int[] { -2, -1, 0, 1, 2, 3, 3, 9, 5, 3, 1, 1, 1, 2, -7, 10, 11, -1, 0, 0, 5, -5, -8, 2, 3 },
              new int[] { 2, 1, 0, 1, 2, 3, 3, 9, 5, 3, 1, 1, 1, 2, 7, 10, 11, 1, 0, 0, 5, 5, 12, 2, 3 },
              new int[] { 2, 1, 1, 1, 2, 3, 3, 9, 5, 3, 1, 1, 1, 2, 7, 10, 11, 1, 4, 4, 5, 5, 12, 2, 3 },
              new int[] { -2, 0, 1, 2, -2, -3, -3, -8, -5, -3, 3, 4, 5, -2, -7, -8, -8, 6, -4, -4, -5, -5, -8, -2, -3 },
              new int[] { -2, -1, 1, -1, -2, -3, -3, -8, -5, -3, -1, -1, -1, -2, -7, -8, -8, -1, 2, 3, -5, -5, -8, -2, -3 },
              new int[] { 1, 2, 3, 4, 5 },
              new int[] { 2, 3, 4 },
              new int[] { -3, -1, -3, 0 },
              new int[] { 4, 2, 5, 2 },
              new int[] { 4, -2, -3, 2 },
              new int[] { -2, 89, 5, 3, 1, 1, 15, -8, 2, -33 },
              new int[] { 1, 2, 4, 1, 2, 5, 1, 1, 1, 2, 6, 7, 8 },
              new int[] { 1, -2, -3, -1, 2, 4, 1, 1, -1, -2, -3, 5, 6 },
              new int[] { 0, 8, 16, 17, 18, -15, -15, -8, 2, -3 },
              new int[] { 6 }
            };
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                _main.Task6(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i].Length, input[i].Length);
                for (int j = 0; j < answer[i].Length; j++)
                {
                    Assert.AreEqual(answer[i][j], input[i][j], $"Test {i} failed (index {j})");
                }
            }
        }
        [TestMethod]
        public void Test07()
        {
            // Arrange
            var input = new int[][] {
                new int[] { -2, -1, 0, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, -7, 8, 8, -1, 0, 0, 5, -5, -8, 2, 3 },
                new int[] { 2, 1, 0, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, 7, 8, 8, 1, 0, 0, 5, 5, 8, 2, 3 },
                new int[] { 2, 1, 1, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, 7, 8, 8, 1, 4, 4, 5, 5, 8, 2, 3 },
                new int[] { -2, -1, -1, -1, -2, -3, -3, -8, -5, -3, -1, -1, -1, -2, -7, -8, -8, -1, -4, -4, -5, -5, -8, -2, -3 },
                new int[] { -2, -1, 0, -1, -2, -3, -3, -8, -5, -3, -1, -1, -1, -2, -7, -8, -8, -1, 0, 0, -5, -5, -8, -2, -3 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 1, 1, 1 },
                new int[] { -3, -2, -3, -2 },
                new int[] { 3, 2, 3, 2 },
                new int[] { 3, -2, -3, 2 },
                new int[] { -2, 88, 5, 3, 1, 1, 15, -8, 2, -33 },
                new int[] { 1, 2, 3, 1, 2, 3, 1, 1, 1, 2, 3, 3, 3 },
                new int[] { 1, -2, -3, -1, 2, 3, 1, 1, -1, -2, -3, 3, 3 },
                new int[] { 0, 8, 15, 15, 15, -15, -15, -8, 2, -3 },
                new int[] { 5 }
            };
            var answer = new int[][] {
                    new int[] { -2, -1, 0, 1, 2, 3, 3, 6, 5, 3, 1, 1, 1, 2, -7, 20, 28, -1, 0, 0, 5, -5, -8, 2, 3 },
                new int[] { 2, 1, 0, 1, 2, 3, 3, 12, 5, 3, 1, 1, 1, 2, 7, 40, 48, 1, 0, 0, 5, 5, 67, 2, 3 },
                new int[] { 2, 1, 1, 1, 2, 3, 3, 13, 5, 3, 1, 1, 1, 2, 7, 41, 49, 1, 4, 4, 5, 5, 76, 2, 3 },
                new int[] { -2, -2, -3, -4, -2, -3, -3, -8, -5, -3, -29, -30, -31, -2, -7, -8, -8, -57, -4, -4, -5, -5, -8, -2, -3 },
                new int[] { -2, -1, -3, -1, -2, -3, -3, -8, -5, -3, -1, -1, -1, -2, -7, -8, -8, -1, -57, -57, -5, -5, -8, -2, -3 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 0, 1, 2 },
                new int[] { -3, -3, -3, -8 },
                new int[] { 0, 2, 5, 2 },
                new int[] { 0, -2, -3, 2 },
                new int[] { -2, -2, 5, 3, 1, 1, 15, -8, 2, -33 },
                new int[] { 1, 2, 3, 1, 2, 9, 1, 1, 1, 2, 17, 20, 23 },
                new int[] { 1, -2, -3, -1, 2, -3, 1, 1, -1, -2, -3, -4, -1 },
                new int[] { 0, 8, 8, 23, 38, -15, -15, -8, 2, -3 },
                new int[] { 0 }
            };
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                _main.Task7(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i].Length, input[i].Length);
                for (int j = 0; j < answer[i].Length; j++)
                {
                    Assert.AreEqual(answer[i][j], input[i][j], $"Test {i} failed (index {j})");
                }
            }
        }
        [TestMethod]
        public void Test08()
        {
            // Arrange
            var input = new int[][] {
              new int[] { -2, -1, 0, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, -7, 8, 8, -1, 0, 0, 5, -5, -8, 2, 3 },
              new int[] { 2, 1, 0, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, 7, 8, 8, 1, 0, 0, 5, 5, 8, 2, 3 },
              new int[] { 2, 1, 1, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, 7, 8, 8, 1, 4, 4, 5, 5, 8, 2, 3 },
              new int[] { -2, -1, -1, -1, -2, -3, -3, -8, -5, -3, -1, -1, -1, -2, -7, -8, -8, -1, -4, -4, -5, -5, -8, -2, -3 },
              new int[] { -2, -1, 0, -1, -2, -3, -3, -8, -5, -3, -1, -1, -1, -2, -7, -8, -8, -1, 0, 0, -5, -5, -8, -2, -3 },
              new int[] { 0, 0, 0, 0, 0 },
              new int[] { 1, 1, 1 },
              new int[] { -3, -2, -3, -2 },
              new int[] { 3, 2, 3, 2 },
              new int[] { 3, -2, -3, 2 },
              new int[] { -2, 88, 5, 3, 1, 1, 15, -8, 2, -33 },
              new int[] { 1, 2, 3, 1, 2, 3, 1, 1, 1, 2, 3, 3, 3 },
              new int[] { 1, -2, -3, -1, 2, 3, 1, 1, -1, -2, -3, 3, 3 },
              new int[] { 0, 8, 15, 15, 15, -15, -15, -8, 2, -3 },
              new int[] { 5 }
            };
            var answer = new int[] { 4, 4, 4, 4, 4, 1, 1, 2, 2, 3, 4, 2, 4, 2, 1 };
            var test = new int[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task8(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i], $"Test {i} failed");
            }
        }
        [TestMethod]
        public void Test09()
        {
            // Arrange
            var input = new int[][] {
                new int[] { -2, -1, 0, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, -7, 8, 8, -1, 0, 0, 5, -5, -8, 2, 3 },
                new int[] { 2, 1, 0, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, 7, 8, 8, 1, 0, 0, 5, 5, 8, 2, 3 },
                new int[] { 2, 1, 1, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, 7, 8, 8, 1, 4, 4, 5, 5, 8, 2, 3 },
                new int[] { -2, -1, -1, -1, -2, -3, -3, -8, -5, -3, -1, -1, -1, -2, -7, -8, -8, -1, -4, -4, -5, -5, -8, -2, -3 },
                new int[] { -2, -1, 0, -1, -2, -3, -3, -8, -5, -3, -1, -1, -1, -2, -7, -8, -8, -1, 0, 0, -5, -5, -8, -2, -3 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 1, 1, 1 },
                new int[] { -3, -2, -3, -2 },
                new int[] { 3, 2, 3, 2 },
                new int[] { 3, -2, -3, 2 },
                new int[] { -2, 88, 5, 3, 1, 1, 15, -8, 2, -33 },
                new int[] { 1, 2, 3, 1, 2, 3, 1, 1, 1, 2, 3, 3, 3 },
                new int[] { 1, -2, -3, -1, 2, 3, 1, 1, -1, -2, -3, 3, 3 },
                new int[] { 0, 8, 15, 15, 15, -15, -15, -8, 2, -3 },
                new int[] { 5 }
            };
            var answer = new int[][] {
              new int[] { -8, -1, -7, 1, -2, 3, 0, 8, 0, 3, 1, 1, 1, 2, 2, 8, 3, -1, 3, 0, 5, -5, 5, 2, 8 },
              new int[] { 0, 1, 0, 1, 1, 3, 1, 8, 2, 3, 2, 1, 3, 2, 3, 8, 5, 1, 5, 0, 7, 5, 8, 2, 8 },
              new int[] { 1, 1, 1, 1, 1, 3, 2, 8, 2, 3, 3, 1, 3, 2, 4, 8, 5, 1, 5, 4, 7, 5, 8, 2, 8 },
              new int[] { -8, -1, -8, -1, -7, -3, -5, -8, -5, -3, -4, -1, -3, -2, -3, -8, -2, -1, -2, -4, -1, -5, -1, -2, -1 },
              new int[] { -8, -1, -8, -1, -7, -3, -5, -8, -5, -3, -3, -1, -3, -2, -2, -8, -2, -1, -1, 0, -1, -5, 0, -2, 0 },
              new int[] { 0, 0, 0, 0, 0 },
              new int[] { 1, 1, 1 },
              new int[] { -3, -2, -3, -2 },
              new int[] { 3, 2, 3, 2 },
              new int[] { -3, -2, 3, 2 },
              new int[] { -2, 88, 1, 3, 2, 1, 5, -8, 15, -33 },
              new int[] { 1, 2, 1, 1, 1, 3, 2, 1, 3, 2, 3, 3, 3 },
              new int[] { -3, -2, -3, -1, -1, 3, 1, 1, 1, -2, 2, 3, 3 },
              new int[] { -15, 8, 0, 15, 2, -15, 15, -8, 15, -3 },
              new int[] { 5 }
            };
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                _main.Task9(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i].Length, input[i].Length);
                for (int j = 0; j < answer[i].Length; j++)
                {
                    Assert.AreEqual(answer[i][j], input[i][j], $"Test {i} failed (index {j})");
                }
            }
        }
        [TestMethod]
        public void Test10()
        {
            // Arrange
            var input = new int[][] {
                new int[] { -2, -1, 0, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, -7, 8, 8, -1, 0, 0, 5, -5, -8, 2, 3 },
                new int[] { 2, 1, 0, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, 7, 8, 8, 1, 0, 0, 5, 5, 8, 2, 3 },
                new int[] { 2, 1, 1, 1, 2, 3, 3, 8, 5, 3, 1, 1, 1, 2, 7, 8, 8, 1, 4, 4, 5, 5, 8, 2, 3 },
                new int[] { -2, -1, -1, -1, -2, -3, -3, -8, -5, -3, -1, -1, -1, -2, -7, -8, -8, -1, -4, -4, -5, -5, -8, -2, -3 },
                new int[] { -2, -1, 0, -1, -2, -3, -3, -8, -5, -3, -1, -1, -1, -2, -7, -8, -8, -1, 0, 0, -5, -5, -8, -2, -3 },
                new int[] { 0, 0, 0, 0, 0 },
                new int[] { 1, 1, 1 },
                new int[] { -3, -2, -3, -2 },
                new int[] { 3, 2, 3, 2 },
                new int[] { 3, -2, -3, 2 },
                new int[] { -2, 88, 5, 3, 1, 1, 15, -8, 2, -33 },
                new int[] { 1, 2, 3, 1, 2, 3, 1, 1, 1, 2, 3, 3, 3 },
                new int[] { 1, -2, -3, -1, 2, 3, 1, 1, -1, -2, -3, 3, 3 },
                new int[] { 0, 8, 15, 15, 15, -15, -15, -8, 2, -3 },
                new int[] { 5 }
            };
            var answer = new int[][] {
                new int[] { -2, -1, 0, 1, 2, 3, 8, 5, -7, -5, -8 },
                new int[] { 2, 1, 0, 3, 8, 5, 7 },
                new int[] { 2, 1, 3, 8, 5, 7, 4 },
                new int[] { -2, -1, -3, -8, -5, -7, -4 },
                new int[] { -2, -1, 0, -3, -8, -5, -7 },
                new int[] { 0 },
                new int[] { 1 },
                new int[] { -3, -2 },
                new int[] { 3, 2 },
                new int[] { 3, -2, -3, 2 },
                new int[] { -2, 88, 5, 3, 1, 15, -8, 2, -33 },
                new int[] { 1, 2, 3 },
                new int[] { 1, -2, -3, -1, 2, 3 },
                new int[] { 0, 8, 15, -15, -8, 2, -3 },
                new int[] { 5 }
            };
            var test = new int[answer.Length][];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task10(input[i]);
            }
            // Assert
            Assert.AreNotEqual(input, test);
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i].Length, test[i].Length);
                for (int j = 0; j < answer[i].Length; j++)
                {
                    Assert.AreEqual(answer[i][j], test[i][j], $"Test {i} failed (index {j})");
                }
            }
        }
        [TestMethod]
        public void Test11()
        {
            // Arrange
            var inputA = new double[] { 1, 2.5, 3, 0.01, 0.5, 1.6, 2.7, 8.8, 9.01, 10, -5, -0.3, -0.01, 0, 0 };
            var inputB = new double[] { 2, 3.5, 3, 0.8, 1.5, 3.33, 1.1, 1.1, -1.1, -1.2, 7, 0.8, -0.08, 1, 0 };
            var inputN = new int[] { 2, 3, 3, 8, 5, 3, 2, 2, 2, 2, 7, 8, 8, 1, 0 };
            var answer = new double[][] {
                new double[] { 2 },
                new double[] { 3.5 },
                null,
                new double[] { 0.46142857142857147, 0.5742857142857143, 0.6871428571428572, 0.8 },
                new double[] { 1.25, 1.5 },
                new double[] { 3.33 },
                new double[] { 2.7 },
                new double[] { 8.8 },
                new double[] {  },
                new double[] {  },
                new double[] { 5, 7 },
                new double[] { 0.4857142857142858, 0.642857142857143, 0.8 },
                new double[] {  },
                null,
                null
            };
            var test = new double[answer.Length][];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task11(inputA[i], inputB[i], inputN[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                if (answer[i] == null)
                {
                    Assert.IsNull(test[i]);
                    continue;
                }
                Assert.AreEqual(answer[i].Length, test[i].Length);
                for (int j = 0; j < answer[i].Length; j++)
                {
                    Assert.AreEqual(answer[i][j], test[i][j], E, $"Test {i} failed (index {j})");
                }
            }
        }
        [TestMethod]
        public void Test12()
        {
            // Arrange
            var input = new int[][] {
              new int[] { 1, 2, 3, 3, 5, 3, 1, 1, 1, 2, 5, 2, 3 },
              new int[] { 2, 1, 1, 2, 3, 3, 5, 3, 1, 1, 1, 2, 1,5, 5, 2, 3 },
              new int[] { 2, 1, 1, 1, 2, 3, 3 },
              new int[] { 6, 6, 6, 6, 6, 6, 6 },
              new int[] { 1, 2, 3, 4, 5, 6 },
              new int[] { 6, 5, 4, 3, 2, 1 },
              new int[] { 1, 1, 1, 1, 1, 1 },
              new int[] { 2, 2, 2, 2, 2, 2 },
              new int[] { 3, 2, 3, 2},
              new int[] { 6, 3, 6, 3, 6, 3, 6, 3, 6, 3, 6, 3 },
              new int[] { 5, 3, 1 },
              new int[] { 1, 2, 3 },
              new int[] { 1, 2, 3, 6, 6, 6 },
              new int[] { 5, 5, 5, 5, 5, 5 },
              new int[] { 5 }
            };
            var answer = new int[] { 6, 9, 2, 0, 3, 0, 0, 1, 0, 4, 0, 0, 3, 4, 0 };
            var test = new int[answer.Length];
            // Act
            for (int i = 0; i < answer.Length; i++)
            {
                test[i] = _main.Task12(input[i]);
            }
            // Assert
            for (int i = 0; i < answer.Length; i++)
            {
                Assert.AreEqual(answer[i], test[i], $"Test {i} failed");
            }
        }
    }
}
