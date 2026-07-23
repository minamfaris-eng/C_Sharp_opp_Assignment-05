namespace Assignment5.Interface
{
    public interface IBookable
    {
        bool Book();
        bool Cancel();
        bool IsBooked { get; }
    }
}
