using System;

class Movie
{
    public string title;
    public string director;
    public int year;
    public double rating;
    public Movie prev;
    public Movie next;

    public Movie(string title, string director, int year, double rating)
    {
        this.title = title;
        this.director = director;
        this.year = year;
        this.rating = rating;
        this.prev = null;
        this.next = null;
    }
}

class MovieList
{
    private Movie head;
    private Movie tail;

    public void AddMovieAtBeginning(string title, string director, int year, double rating)
    {
        Movie newMovie = new Movie(title, director, year, rating);
        if (head == null)
        {
            head = tail = newMovie;
            return;
        }
        newMovie.next = head;
        head.prev = newMovie;
        head = newMovie;
    }

    public void AddMovieAtEnd(string title, string director, int year, double rating)
    {
        Movie newMovie = new Movie(title, director, year, rating);
        if (tail == null)
        {
            head = tail = newMovie;
            return;
        }
        tail.next = newMovie;
        newMovie.prev = tail;
        tail = newMovie;
    }

    public void AddMovieAtPosition(string title, string director, int year, double rating, int position)
    {
        if (position <= 0)
        {
            AddMovieAtBeginning(title, director, year, rating);
            return;
        }
        Movie newMovie = new Movie(title, director, year, rating);
        Movie temp = head;
        for (int i = 0; i < position - 1 && temp != null; i++)
        {
            temp = temp.next;
        }
        if (temp == null || temp.next == null)
        {
            AddMovieAtEnd(title, director, year, rating);
            return;
        }
        newMovie.next = temp.next;
        newMovie.prev = temp;
        temp.next.prev = newMovie;
        temp.next = newMovie;
    }

    public void RemoveMovie(string title)
    {
        Movie temp = head;
        while (temp != null && temp.title != title)
        {
            temp = temp.next;
        }
        if (temp == null) 
            return;
        if (temp == head) 
            head = temp.next;
        if (temp == tail) 
            tail = temp.prev;
        if (temp.prev != null) 
            temp.prev.next = temp.next;
        if (temp.next != null) 
            temp.next.prev = temp.prev;
    }

    public Movie SearchByDirectorOrRating(string director, double rating)
    {
        Movie temp = head;
        while (temp != null)
        {
            if (temp.director == director || temp.rating == rating)
                return temp;
            temp = temp.next;
        }
        return null;
    }

    public void UpdateRating(string title, double newRating)
    {
        Movie temp = head;
        while (temp != null)
        {
            if (temp.title == title)
            {
                temp.rating = newRating;
                return;
            }
            temp = temp.next;
        }
    }

    public void DisplayMoviesForward()
    {
        Movie temp = head;
        while (temp != null)
        {
            Console.WriteLine($"Title: {temp.title}, Director: {temp.director}, Year: {temp.year}, Rating: {temp.rating}");
            temp = temp.next;
        }
    }

    public void DisplayMoviesReverse()
    {
        Movie temp = tail;
        while (temp != null)
        {
            Console.WriteLine($"Title: {temp.title}, Director: {temp.director}, Year: {temp.year}, Rating: {temp.rating}");
            temp = temp.prev;
        }
    }
}

public class MovieManager
{
    public static void Main()
    {
        MovieList movieList = new MovieList();
        movieList.AddMovieAtBeginning("Inception", "Christopher Nolan", 2010, 8.8);
        movieList.AddMovieAtEnd("Interstellar", "Christopher Nolan", 2014, 8.6);
        movieList.AddMovieAtPosition("The Dark Knight", "Christopher Nolan", 2008, 9.0, 1);

        Console.WriteLine("Movies in forward order:");
        movieList.DisplayMoviesForward();

        Console.WriteLine("\nMovies in reverse order:");
        movieList.DisplayMoviesReverse();

        Console.WriteLine("\nAfter removing 'Interstellar':");
        movieList.RemoveMovie("Interstellar");
        movieList.DisplayMoviesForward();

        Console.WriteLine("\nUpdating rating of 'Inception':");
        movieList.UpdateRating("Inception", 9.0);
        movieList.DisplayMoviesForward();
    }
}