using System;

// ======= ESTRUTURAS DE MENSAGEM =======

public class TextMessage
{
    public string Message { get; set; }
    public DateTime DataEnvio { get; set; } = DateTime.Now;
}

public class PhotoMessage
{
    public string Message { get; set; }
    public string File { get; set; }
    public string Format { get; set; }
    public DateTime DataEnvio { get; set; } = DateTime.Now;
}

public class VideoMessage
{
    public string Message { get; set; }
    public string File { get; set; }
    public string Format { get; set; }
    public int Duration { get; set; }
    public DateTime DataEnvio { get; set; } = DateTime.Now;
}

public class FileMessage
{
    public string Message { get; set; }
    public string File { get; set; }
    public string Format { get; set; }
    public DateTime DataEnvio { get; set; } = DateTime.Now;
}

// ======= CANAL WHATSAPP =======

public class WhatsApp
{
    public void EnviarMensagem(string numero, TextMessage message)
    {
        Console.WriteLine($"Enviando mensagem de texto para o número {numero} no WhatsApp");
        Console.WriteLine($"Mensagem: {message.Message}");
    }

    public void EnviarMensagem(string numero, VideoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de vídeo para o número {numero} no WhatsApp");
        Console.WriteLine($"Mensagem: {message.Message}");
        Console.WriteLine($"Arquivo: {message.File}");
        Console.WriteLine($"Formato: {message.Format}");
        Console.WriteLine($"Duração: {message.Duration} segundos");
    }

    public void EnviarMensagem(string numero, PhotoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de foto para o número {numero} no WhatsApp");
        Console.WriteLine($"Mensagem: {message.Message}");
        Console.WriteLine($"Arquivo: {message.File}");
        Console.WriteLine($"Formato: {message.Format}");
    }

    public void EnviarMensagem(string numero, FileMessage message)
    {
        Console.WriteLine($"Enviando mensagem de arquivo para o número {numero} no WhatsApp");
        Console.WriteLine($"Mensagem: {message.Message}");
        Console.WriteLine($"Arquivo: {message.File}");
        Console.WriteLine($"Formato: {message.Format}");
    }
}

// ======= CANAL INSTAGRAM =======

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

// ======= CANAL TELEGRAM =======

public class Telegram
{
    public void EnviarMensagem(string contato, TextMessage message)
    {
        Console.WriteLine($"Enviando mensagem de texto para o contato {contato} no Telegram");
        Console.WriteLine($"Mensagem: {message.Message}");
    }

    public void EnviarMensagem(string contato, VideoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de vídeo para o contato {contato} no Telegram");
        Console.WriteLine($"Mensagem: {message.Message}");
        Console.WriteLine($"Arquivo: {message.File}");
        Console.WriteLine($"Formato: {message.Format}");
        Console.WriteLine($"Duração: {message.Duration} segundos");
    }

    public void EnviarMensagem(string contato, PhotoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de foto para o contato {contato} no Telegram");
        Console.WriteLine($"Mensagem: {message.Message}");
        Console.WriteLine($"Arquivo: {message.File}");
        Console.WriteLine($"Formato: {message.Format}");
    }

    public void EnviarMensagem(string contato, FileMessage message)
    {
        Console.WriteLine($"Enviando mensagem de arquivo para o contato {contato} no Telegram");
        Console.WriteLine($"Mensagem: {message.Message}");
        Console.WriteLine($"Arquivo: {message.File}");
        Console.WriteLine($"Formato: {message.Format}");
    }
}

// ======= CANAL FACEBOOK =======

public class Facebook
{
    public void EnviarMensagem(string usuario, TextMessage message)
    {
        Console.WriteLine($"Enviando mensagem de texto para o usuário {usuario} no Facebook");
        Console.WriteLine($"Mensagem: {message.Message}");
    }

    public void EnviarMensagem(string usuario, VideoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de vídeo para o usuário {usuario} no Facebook");
        Console.WriteLine($"Mensagem: {message.Message}");
        Console.WriteLine($"Arquivo: {message.File}");
        Console.WriteLine($"Formato: {message.Format}");
        Console.WriteLine($"Duração: {message.Duration} segundos");
    }

    public void EnviarMensagem(string usuario, PhotoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de foto para o usuário {usuario} no Facebook");
        Console.WriteLine($"Mensagem: {message.Message}");
        Console.WriteLine($"Arquivo: {message.File}");
        Console.WriteLine($"Formato: {message.Format}");
    }

    public void EnviarMensagem(string usuario, FileMessage message)
    {
        Console.WriteLine($"Enviando mensagem de arquivo para o usuário {usuario} no Facebook");
        Console.WriteLine($"Mensagem: {message.Message}");
        Console.WriteLine($"Arquivo: {message.File}");
        Console.WriteLine($"Formato: {message.Format}");
    }
}

// ======= PROGRAMA PRINCIPAL =======

class Program
{
    static void Main()
    {
        var texto = new TextMessage { Message = "Olá, tudo bem?" };
        var foto = new PhotoMessage { Message = "Veja essa foto!", File = "foto.png", Format = "png" };
        var video = new VideoMessage { Message = "Assista ao vídeo!", File = "video.mp4", Format = "mp4", Duration = 30 };
        var arquivo = new FileMessage { Message = "Segue o documento", File = "doc.pdf", Format = "pdf" };

        var whatsapp = new WhatsApp();
        var instagram = new Instagram();
        var telegram = new Telegram();
        var facebook = new Facebook();

        Console.WriteLine("\n--- WHATSAPP ---");
        whatsapp.EnviarMensagem("+5511999999999", texto);
        whatsapp.EnviarMensagem("+5511999999999", foto);
        whatsapp.EnviarMensagem("+5511999999999", video);
        whatsapp.EnviarMensagem("+5511999999999", arquivo);

        Console.WriteLine("\n--- INSTAGRAM ---");
        instagram.EnviarMensagem("usuario_insta", texto);
        instagram.EnviarMensagem("usuario_insta", foto);
        instagram.EnviarMensagem("usuario_insta", video);
        instagram.EnviarMensagem("usuario_insta", arquivo);

        Console.WriteLine("\n--- TELEGRAM ---");
        telegram.EnviarMensagem("@usuarioTelegram", texto);
        telegram.EnviarMensagem("@usuarioTelegram", foto);
        telegram.EnviarMensagem("@usuarioTelegram", video);
        telegram.EnviarMensagem("@usuarioTelegram", arquivo);

        Console.WriteLine("\n--- FACEBOOK ---");
        facebook.EnviarMensagem("usuario_facebook", texto);
        facebook.EnviarMensagem("usuario_facebook", foto);
        facebook.EnviarMensagem("usuario_facebook", video);
        facebook.EnviarMensagem("usuario_facebook", arquivo);
    }
}


