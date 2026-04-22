using System;
using System.Security.Cryptography;


namespace ClubeDaLeitura.ConsoleApp.Dominio;

public class Emprestimo
{

    public string Id { get; set; } = string.Empty;
    public Revista Revista { get; set; }
    public Amigo Amigo { get; set; }
    public DateTime Abertura { get; set; } = DateTime.MinValue;
    public DateTime Conclusao { get; set; } = DateTime.MinValue;
    public StatusEmprestimo Status { get; set; } = StatusEmprestimo.Indefinido;


    public Emprestimo(Revista revista, Amigo amigo)
    {
        Id = Convert
        .ToHexString(RandomNumberGenerator.GetBytes(20))
        .ToLower()
        .Substring(0, 7);

        Revista = revista;
        Amigo = amigo;

    }

    public string[] Validar()
    {
        string erros = string.Empty;

        if (Revista == null)
            erros += "O campo \"Revista\" deve conter uma revista válida;";

        if (Amigo == null)
            erros += "O campo \"Amigo\" deve conter um amigo válido;";

        return erros.Split(';', StringSplitOptions.RemoveEmptyEntries);
    }

}
