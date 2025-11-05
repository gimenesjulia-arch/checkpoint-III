public class FileMessage : MessageBase
{
    public string File { get; set; }       // Caminho ou nome do arquivo
    public string Format { get; set; }     // Tipo de arquivo (ex: "pdf", "docx", "zip")

    public FileMessage(string message)
        : base(message)
    {
    }
}

