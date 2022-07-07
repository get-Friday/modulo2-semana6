namespace modulo2_semana6_tests;

public class VerdadeiroFalsoTest : ConfiguracaoHostApi
{
    [Theory]
    [InlineData("verdadeiro")]
    public async Task Test_Api_True_False_Success(string type)
    {
        var result = await client.GetAsync($"/ExercicioVerdadeiroFalso/{type}");
        Assert.NotNull(result);

        var responseApi = await result.Content.ReadAsStringAsync();
        Assert.NotNull(responseApi);
        Assert.Equal("verdadeiro", responseApi);
    }

    [Theory]
    [InlineData("Peixe")]
    [InlineData("VERDADEIRO")]
    public async Task Test_Api_True_False_Failure(string type)
    {
        var result = await client.GetAsync($"/ExercicioVerdadeiroFalso/{type}");
        Assert.NotNull(result);

        var responseApi = await result.Content.ReadAsStringAsync();
        Assert.NotNull(responseApi);
        Assert.NotEqual("Texto diferente de verdadeiro ou falso", responseApi);
    }
}