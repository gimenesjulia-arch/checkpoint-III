// See https://aka.ms/new-console-template for more information
Console.WriteLine("Para qual canal você quer enviar mensagem?");
Console.WriteLine("1.  WhatsApp");
Console.WriteLine("2. Telegram");  
Console.WriteLine("3. Instagram");  
Console.WriteLine("4. Facebook");

int canal = 0;
string resposta = Console.ReadLine();
if (int.TryParse(resposta, out canal))
{
  Console.WriteLine("Opção inválida");
  return;       
}   

TextMessage textMessage = new TextMessage("Olá);
VideoMessage video = new VideoMessage("Olá");
