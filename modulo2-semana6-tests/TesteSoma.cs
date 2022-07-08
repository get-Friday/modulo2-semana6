namespace modulo2_semana6_tests;

public class SomaTest : ConfiguracaoHostApi
{
    [Theory]
    [InlineData(5, 3)]
    public async Task Test_Sum_Success(int x, int y)
    {
        var result = await client.GetAsync($"/ExercicioSoma/{x}/{y}");
        Assert.NotNull(result);

        var responseApi = await result.Content.ReadAsStringAsync();
        Assert.NotNull(responseApi);
        Assert.Equal($"{x} + {y} = {x + y}", responseApi);
    }

    [Theory]
    [InlineData(10, 3)]
    public async Task Test_Sum_Failure(int x, int y)
    {
        var result = await client.GetAsync($"/ExercicioSoma/{x}/{y}");
        Assert.NotNull(result);

        var responseApi = await result.Content.ReadAsStringAsync();
        Assert.NotNull(responseApi);
        Assert.Equal($"{x + y}", responseApi);
    }
}

