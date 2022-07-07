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
}