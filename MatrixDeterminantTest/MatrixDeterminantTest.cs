namespace MatrixDeterminantTest
{
    public class MatrixDeterminantTest
    {
        [Fact]
        public void CalculateDeterminant_1_1()
        {
            //arrange
            var matrix = new int[][] { new[] { 1 } };
            var expected = 1;
            //act 
            var actual = MatrixDeterminant.MatrixDeterminant.CalculateDeterminant(matrix);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateDeterminant_1_3_2_5_1()
        {
            //arrange
            var matrix = new int[][] { new[] { 1, 3 }, new[] { 2, 5 } };
            var expected = -1;
            //act 
            var actual = MatrixDeterminant.MatrixDeterminant.CalculateDeterminant(matrix);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateDeterminant_1_2_3_4_5_6_7_8_9_0()
        {
            //arrange
            var matrix = new int[][] { new[] { 1, 2, 3 }, new[] { 4, 5, 6 }, new[] { 7, 8, 9 } };
            var expected = 0;
            //act 
            var actual = MatrixDeterminant.MatrixDeterminant.CalculateDeterminant(matrix);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateDeterminant_2_5_3_1__2__1_1_3_4__20()
        {
            //arrange
            var matrix = new int[][] { new[] { 2, 5, 3 }, new[] { 1, -2, -1 }, new[] { 1, 3, 4 } };
            var expected = -20;
            //act 
            var actual = MatrixDeterminant.MatrixDeterminant.CalculateDeterminant(matrix);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateDeterminant_1_2_3_4_5_6_7_8_9_10_11_12_13_14_15_16_0()
        {
            //arrange
            var matrix = new int[][] { new[] { 1, 2, 3, 4 },
                                       new[] { 5, 6, 0, 8 },
                                       new[] { 9, 0, 11, 12 }, 
                                       new[] { 13, 14, 15, 16 } };
            var expected = 2520;
            //act 
            var actual = MatrixDeterminant.MatrixDeterminant.CalculateDeterminant(matrix);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateDeterminant_6_0_8_9_10_11_12_13_14_15_16_0()
        {
            //arrange
            var matrix = new int[][] { new[] { 6, 0, 8 },
                                       new[] { 0, 11, 12 },
                                       new[] { 14, 15, 16 } };
            var expected = -1256;
            //act 
            var actual = MatrixDeterminant.MatrixDeterminant.CalculateDeterminant(matrix);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateDeterminant_5_0_8_9_10_11_12_13_14_15_16_0()
        {
            //arrange
            var matrix = new int[][] { new[] { 5, 0, 8 },
                                       new[] { 9, 11, 12 },
                                       new[] { 13, 15, 16 } };
            var expected = -84;
            //act 
            var actual = MatrixDeterminant.MatrixDeterminant.CalculateDeterminant(matrix);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateDeterminant_5_6_8_9_10_11_12_13_14_15_16_0()
        {
            //arrange
            var matrix = new int[][] { new[] { 5, 6, 8 },
                                       new[] { 9, 0, 12 },
                                       new[] { 13, 14, 16 } };
            var expected = 240;
            //act 
            var actual = MatrixDeterminant.MatrixDeterminant.CalculateDeterminant(matrix);
            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CalculateDeterminant_5_6_0_9_10_11_12_13_14_15_16_0()
        {
            //arrange
            var matrix = new int[][] { new[] { 5, 6, 0 },
                                       new[] { 9, 0, 11 },
                                       new[] { 13, 14, 15 } };
            var expected = -722;
            //act 
            var actual = MatrixDeterminant.MatrixDeterminant.CalculateDeterminant(matrix);
            //assert
            Assert.Equal(expected, actual);
        }

    }
}