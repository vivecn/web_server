namespace web_server.controllers;

public interface IRangeSelector
{
    public int Start_Index { get; set; }
    public int Count { get; set; }
}

public interface IIndexSelector
{
    public int Index { get; set; }
}

public interface IKeySelector
{
    public string Key { get; set; }
}