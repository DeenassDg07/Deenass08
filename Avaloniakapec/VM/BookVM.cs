using Avaloniakapec.DB;
using Avaloniakapec.Model;
using Avaloniakapec.VM.Utils;

namespace Avaloniakapec.VM;

public class BookVM : BaseVM
{
  private readonly Book book;

  public string Isbn
  {
    get => book.Isbn;
    set
    {
      book.Isbn = value;
      OnPropertyChanged();
    }
  }

  public string Title
  {
    get => book.Title;
    set
    {
      book.Title = value;
      OnPropertyChanged();
    }
  }

  public string Author
  {
    get => book.Author;
    set
    {
      book.Author = value;
      OnPropertyChanged();
    }
  }

  public int Year
  {
    get => book.Year;
    set
    {
      book.Year = value;
      OnPropertyChanged();
    }
  }
  public BookVM (Book _book)
  {
    book = _book;
  }
}
