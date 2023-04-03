namespace Core.Models;

public interface IDatabase
{
    int Id { get; set; }
    string Filename { get; set; }
}
