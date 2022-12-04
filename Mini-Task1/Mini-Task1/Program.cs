using  Mini_Task1;


Book book1 = new Book("Ghost", 12.5, "Arthoor Ivanov", 145);
Book book2 = new Book("Lovely Bones", 32.2, "Arthoor Shepchenko", 125);
Book book3 = new Book("Nikolay", 7.9, "Nikolay Krasnorodov", 75);
Book book4 = new Book("Mirror", 32.7, "Secret148", 890);
Book book5 = new Book("War and Peace", 132, "Nikolay Tolstoy", 145);

Library library = new Library(12);

try
{
    library.AddBook(book1);
    library.AddBook(book2);
    library.AddBook(book3);
    library.AddBook(book4);
    library.AddBook(book5);
    library.AddBook(book1);
    library.AddBook(book2);
    library.AddBook(book3);
    library.AddBook(book4);
    library.AddBook(book5);
    library.AddBook(book1);
    library.AddBook(book2);
    library.AddBook(book3);
    library.AddBook(book4);
    library.AddBook(book5);
}
catch (IndexOutOfRangeException )
{

    Console.WriteLine("Limit of Books!");
}



book1.ShowInfo();

book1.Sell();

book1.ShowInfo();

book2.ShowInfo();

book2.Sell();

book2.ShowInfo();



