namespace Program;

public class Class1
{
    protected string _receiver;
    public string Receiver
    {
        get
        {
            return _receiver;
        }
    }
    
    protected int _price;
    public int Price
    {
        get
        {
            return _price;
        }
    }
    
    protected DateTime _date = DateTime.Now;
    public DateTime Date
    {
        get
        {
            return _date;
        }
    }

    public Class1(string receiver, int price, DateTime date)
    {
        _receiver = receiver;
        _price = price;
        _date = date;
    }
}