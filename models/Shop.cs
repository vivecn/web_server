namespace web_server.models;

public class Shop
{
    public Address Address { get; set; }
    public IList<Delicacy> Delicacies { get; set; }
}