

//List<Gift> myGifts = new List<Gift>();
//string[] giftsFromFile = GetDataFromFile();


//foreach (string line in giftsFromFile)
//{
//    string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
//    Gift newGift = new Gift(tempArray[0], tempArray[1]);
//    myGifts.Add(newGift);
//}

//foreach (Gift giftFromList in myGifts)
//{
//    Console.WriteLine($" {giftFromList.Name} wants {giftFromList.Present} for Christmas.");
//}


//static string[] GetDataFromFile()
//{
//    string filePath = @"C:\Data\Week15\frozen.txt";
//    string[] dataFromFile = File.ReadAllLines(filePath);
//    return dataFromFile;
//;
//}


//class Gift
//{
//    string name;
//    string present;
//    public Gift(string _name, string _present)
//    {
//       name = _name;
//       present = _present;
//    }
//    public string Name
//    {
//       get { return name; }
//    }
//    public string Present
//    {

//       get { return present; }
//    }
//}


List<Movie> myMovies = new List<Movie>();
string[] data = GetDataFromMyFile();
foreach (string line in data)
{
    string[] tempArray = line.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(tempArray[0], tempArray[2], tempArray[1]);
    myMovies.Add(newMovie);
}
foreach (Movie movie in myMovies)
{
    Console.WriteLine($"One of my favorite movies {movie.Title} was released in {movie.Year}.Rating: {movie.Rating}");
}
static string[] GetDataFromMyFile()
{
    string filePath = @"C:\Data\Week15\movies.txt";
    return File.ReadAllLines(filePath);
}
class Movie
{
    string title;
    string year;
    string rating;
    public string Title
    {
        get { return title; }
    }
    public string Year
    {
        get { return year; }
    }
    public string Rating
    {
        get { return rating;}
    }
    public Movie(string _title, string _year, string _rating)
    {
        title = _title;
        year = _year;
        rating = _rating;
    }
}