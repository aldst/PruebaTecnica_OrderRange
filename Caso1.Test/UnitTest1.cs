namespace Caso1.Test
{
    public class OrderByTest
    {
        [Theory]
        [InlineData(new int[] { 2, 1, 4, 5 }, new int[] { 2, 4 }, new int[] { 1, 5 })]
        [InlineData(new int[] { 4, 2, 9, 3, 6 }, new int[] { 2, 4, 6 }, new int[] { 3, 9 })]
        [InlineData(new int[] { 58, 60, 55, 48, 57, 73 }, new int[] { 48, 58, 60 }, new int[] { 55, 57, 73 })]
        public void Build(int[] entrada, int[] esperadoPares, int[] esperadoImpares)
        {
            var (pares, impares) = OrderRange.Build(entrada.ToList());

            Assert.Equal(esperadoPares, pares);
            Assert.Equal(esperadoImpares, impares);
        }
    }
}