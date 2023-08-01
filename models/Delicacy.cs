namespace web_server.models;

public class Delicacy
{
    public string Name { get; set; }
    public string Cover_Image { get; set; }
    public string Link { get; set; }
    public string Description { get; set; }
    public float Price { get; set; }
    public Address Address { get; set; }
}