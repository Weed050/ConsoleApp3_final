// See https://aka.ms/new-console-template for more information
using ConsoleApp3.Data;
using ConsoleApp3.Models;
using Microsoft.IdentityModel.Tokens;


var context = new BlogContext();
var IDofAuthorsDB = context.Authors
                                    .Where(s => s.AuthorName == "Remigiusz Mróz")
                                    .ToList();


Console.WriteLine(IDofAuthorsDB);
Console.WriteLine("Hello, World!");
Console.WriteLine("W księgarni są następujący autorzy: ");

Console.WriteLine("Wybierz nr autora i zatwierdź ENTER");

Console.WriteLine();


string? IDofAuthor = Console.ReadLine();

Console.WriteLine("Podaj tytół i wciśnij ENTER");
string? title = Console.ReadLine();

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
            Console.WriteLine("Zapisano");
        }
    }
}

else
{
    Console.WriteLine("Nie podano tego co trzeba, spróbuj ponownie");

}

Console.WriteLine("Press any key to exit...");
Console.ReadKey();