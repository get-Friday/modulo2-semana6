using Microsoft.AspNetCore.Mvc;

namespace modulo2_semana6_api.Controllers;

/// <summary>
/// Exercicio 8
/// </summary>
[ApiController]
[Route("[controller]")]
public class ExercicioSomaController : ControllerBase
{
    /// <summary>
    /// /// Implementar a regra do exercicio 8 aqui dentro do método GET
    /// </summary>
    /// <param name="valorA"></param>
    /// <param name="valorB"></param>
    /// <returns></returns>
    [HttpGet("{valorA}/{valorB}")]
    public string Get(int valorA, int valorB)
    {
        try
        {
            int sum = valorA + valorB;
            if (sum < 10)
            {
                return $"{valorA} + {valorB} = {sum}";
            }

            Random number = new Random();
            throw new Exception($"{number.Next(10, 9999)}");
        }
        catch(Exception ex)
        {
            throw new Exception("Erro ao somar.", ex);
        }

        return "sla";
    }
}
