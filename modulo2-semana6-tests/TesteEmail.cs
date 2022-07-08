namespace modulo2_semana6_tests;

public class TesteEmail : ConfiguracaoHostApi
{
    [Theory]
    [InlineData("email@email.com")]
    public async Task Test_Api_Email_Request_Success(string email)
    {
        var result = await client.GetAsync($"/ExercicioEmail/{email}");
        Assert.NotNull(result);

        var responseApi = await result.Content.ReadAsStringAsync();
        Assert.NotNull(responseApi);
        Assert.Equal(email, responseApi);
    }
}

