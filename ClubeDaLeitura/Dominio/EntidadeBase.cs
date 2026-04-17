using System;
using System.Security.Cryptography;

namespace ClubeDaLeitura.ConsoleApp.Dominio;

public class EntidadeBase
{
    public string Id { get; set; } = string.Empty;

    public EntidadeBase()
    {
        Id = Convert
        .ToHexString(RandomNumberGenerator.GetBytes(20))
        .ToLower()
        .Substring(0, 7);
    }
}
