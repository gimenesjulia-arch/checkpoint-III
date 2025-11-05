using System;

public class Instagram
{
    public void EnviarMensagem(string usuario, TextMessage message)
    {
        Console.WriteLine($"Enviando mensagem de texto para o usuário {usuario} no Instagram");
        Console.WriteLine($"Mensagem: {message.Message}");
    }

    public void EnviarMensagem(string usuario, VideoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de vídeo para o usuário {usuario} no Instagram");
        Console.WriteLine($"Mensagem: {message.Message}");
        Console.WriteLine($"Arquivo: {message.File}");
        Console.WriteLine($"Formato: {message.Format}");
        Console.WriteLine($"Duração: {message.Duration} segundos");
    }

    public void EnviarMensagem(string usuario, PhotoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de foto para o usuário {usuario} no Instagram");
        Console.WriteLine($"Mensagem: {message.Message}");
        Console.WriteLine($"Arquivo: {message.File}");
        Console.WriteLine($"Formato: {message.Format}");
    }

    public void EnviarMensagem(string usuario, FileMessage message)
    {
        Console.WriteLine($"Enviando mensagem de arquivo para o usuário {usuario} no Instagram");
        Console.WriteLine($"Mensagem: {message.Message}");
        Console.WriteLine($"Arquivo: {message.File}");
        Console.WriteLine($"Formato: {message.Format}");
    }
}

