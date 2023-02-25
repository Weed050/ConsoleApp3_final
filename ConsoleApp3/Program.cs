// See https://aka.ms/new-console-template for more information
using ConsoleApp3.Data;
using ConsoleApp3.Models;


Console.WriteLine("Hello, World!");
Console.WriteLine("W księgarni są następujący autorzy: ");

Console.WriteLine("Wybierz nr autora: ");

string IDofAuthor = Console.ReadLine();

Console.WriteLine("Podaj tytół");
string title = Console.ReadLine();

int IDAuthorINT = 0;
IDAuthorINT = Int16.Parse(IDofAuthor);

if (IDofAuthor != null && title != null)
{
    using (var db = new BlogContext())
    {
        db.Books.Add(new Books { AuthorID = IDAuthorINT, bookName = title });
        db.SaveChanges();

        foreach (var blog in db.Blogs)
        {
            Console.WriteLine(blog.Name);
        }
    }
}

else
{
    Console.WriteLine("Nie podano tego co trzeba, spróbuj ponownie");

}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();