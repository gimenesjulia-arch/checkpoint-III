public class MessageBase
{
    public string Message { get; set; }

    public MessageBase(string message)
    {
        Message = message;
    }
}

public class MediaMessage : MessageBase
{
    public string File { get; set; }
    public string Format { get; set; }

    public MediaMessage(string message) : base(message) { }
}

public class VideoMessage : MediaMessage
{
    public int Duration { get; set; }  // duração em segundos

    public VideoMessage(string message) : base(message) { }
}

