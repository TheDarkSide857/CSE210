using System;

class Entry
{
    public DateTime _date;
    public string _text;
    public string _prompts;
    public Entry(string text, string prompts)
    {
        _date = DateTime.Now;
        _text = text;
        _prompts = prompts;
    }

}