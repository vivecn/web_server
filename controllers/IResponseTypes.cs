namespace web_server.controllers;

public interface IPageResponse<T>
{
    public int Total { get; set; }
    public IList<T> Items { get; set; }
}