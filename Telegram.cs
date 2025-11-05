public class TextMessage
{
    public string Message { get; set; }
    public DateTime DataEnvio { get; set; } = DateTime.Now;
}

public class VideoMessage
{
    public string Message { get; set; }
    public string File { get; set; }
    public string Format { get; set; }
    public int Duration { get; set; }
}

public class PhotoMessage
{
    public string Message { get; set; }
    public string File { get; set; }
    public string Format { get; set; }
}

public class FileMessage
{
    public string Message { get; set; }
    public string File { get; set; }
    public string Format { get; set; }
}

