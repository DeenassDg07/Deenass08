using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Avaloniakapec.Model;
using Avaloniakapec.VM;

namespace Avaloniakapec.DB;

public class DB
{
    private List<Book> ListBook = new List<Book>();

    public void LoadBooks()
    {
        using (var fs = File.OpenRead("books.json"))
        {
            ListBook = JsonSerializer.Deserialize<List<Book>>(fs);
        }
    }
}