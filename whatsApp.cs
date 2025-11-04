public class WhatsApp
{
    public void Enviarmensagem(string numero, TextMessage message)
    {
        Console.WriteLine($"Enviando mensagem de texto para o número {numero}");
    } 

      
public void Enviarmensagem(string numero, VideoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de video para o número {numero}");
    } 
public void Enviarmensagem(string numero, PhotoMessage message)
    {
        Console.WriteLine($"Enviando mensagem de foto para o número {numero}");
    }    

    public void Enviarmensagem(string numero, FileMessage message)
    {
        Console.WriteLine($"Enviando mensagem de arquivo para o número {numero}");
    } 