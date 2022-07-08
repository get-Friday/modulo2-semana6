using Microsoft.AspNetCore.Mvc;
using System.Text.RegularExpressions;

namespace modulo2_semana6_api.Controllers;

/// <summary>
/// Exercicio 4
/// </summary>
[ApiController]
[Route("[controller]")]
public class ExercicioEmailController : ControllerBase
{
    /// <summary>
    /// Implementar a regra do exercicio 4 aqui dentro do GET
    /// </summary>
    /// <param name="email"></param>
    /// <returns></returns>
    [HttpGet("{email}")]
    public string Get(string email)
    {
        string pattern = @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$";
        Regex validation = new (pattern);

        if (DateTime.Now.Minute >= 30)
        {
            throw new ThirthyMinutesException("Erro na requsição o minuto está acima de 30");
        }

        if (!validation.IsMatch(email))
        {
            return "Email inválido";
        }

        return email;
    }
}


[Serializable]
public class ThirthyMinutesException : Exception
{
    public ThirthyMinutesException() { }
    public ThirthyMinutesException(string message) : base(message) { }
    public ThirthyMinutesException(string message, Exception inner) : base(message, inner) { }
    protected ThirthyMinutesException(
      System.Runtime.Serialization.SerializationInfo info,
      System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
}
