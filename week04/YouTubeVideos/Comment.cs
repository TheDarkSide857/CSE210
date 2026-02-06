using System;

public class Comment
{
    public string _commenterName { get; set; }
    public string _commentText { get; set; }
    public DateTime _commentDate { get; set; }
    public Comment(string _commenterName, string _commentText, DateTime _commentDate)
    {
        this._commenterName = _commenterName;
        this._commentText = _commentText;
        this._commentDate = _commentDate;
    }
}
