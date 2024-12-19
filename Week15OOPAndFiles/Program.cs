

using System.Diagnostics.Tracing;
using System.Reflection;

List<Movie> myMovies = new List<Movie>();

string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);

foreach (string line in data)
{
    // andmete lahti rebimine semikooloni järgi
    string[] tempArray = line.Split (new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
    //Console.WriteLine("Temp Array"); // kontrollimaks kas ajutine massiiv splittis read ";" järgi
    //ReadDataFromArray (tempArray); // kontrollimaks kas ajutine massiiv splittis read ";" järgi
    Movie newMovie = new Movie(tempArray[0], tempArray[2]);
    myMovies.Add(newMovie);
}

foreach (Movie movie in myMovies)
{
    Console.WriteLine($"One of my favorite movies {movie.Title} was released in the year {movie.Year}.");
}

static string[] GetDataFromMyFile()
{
    string filePath = @"C:\Data\Week15\movies.txt";
    //string[] DataFromFile = File.ReadAllLines(filePath);
    return File.ReadAllLines(filePath); // return filePath
}

static void ReadDataFromArray(string[] someArray)
{
    foreach(string line in someArray)
    {
        Console.WriteLine(line);
    }
}

class Movie
{
    string title;
    string year;

    public string Title
    {
        get { return title; }
    }
    public string Year
    {
        get { return year; }
    }

    public Movie (string _title, string _year)
    {
        title = _title;
        year = _year;
    }
}