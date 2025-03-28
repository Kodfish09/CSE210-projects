using System;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new List<Comment>();

    //Getters
    public string GetTitle() {
        return _title;
    }
    public string GetAuthor() {
        return _author;
    }
    public int GetLength() {
        return _length;
    }

    //Constructor
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    //Other Methods
    public void AddComment(Comment c) {
        _comments.Add(c);
    }
    public List<Comment> GetComments() {
        return _comments;
    }
    public int NumComments() {
        return _comments.Count();
    }
}