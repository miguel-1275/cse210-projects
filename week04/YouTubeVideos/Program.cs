using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video();

        video1._title = "Book of Mormon: An Introduction";
        video1._author = "The Church of Jesus Chirst of Latter-Day Saints";
        video1._length = 163;

        Comment c1 = new Comment();
        c1._name = "Andres";
        c1._text = "Thank you so much!";
        video1._commentsList.Add(c1);

        Comment c2 = new Comment();
        c2._name = "Benjamin";
        c2._text = "I want more information";
        video1._commentsList.Add(c2);

        Comment c3 = new Comment();
        c3._name = "Rachell";
        c3._text = "Very helpfull";
        video1._commentsList.Add(c3);

        Comment c4 = new Comment();
        c4._name = "Cynthia";
        c4._text = "Well explained";
        video1._commentsList.Add(c4);


        Video video2 = new Video();

        video2._title = "Metallica - Master of Puppets | Guitar Tab";
        video2._author = "Mr. Tabs";
        video2._length = 621;

        Comment d1 = new Comment();
        d1._name = "Miguel";
        d1._text = "Awesome technique";
        video2._commentsList.Add(d1);

        Comment d2 = new Comment();
        d2._name = "Carla";
        d2._text = "Too hard for me :(";
        video2._commentsList.Add(d2);

        Comment d3 = new Comment();
        d3._name = "Diego";
        d3._text = "Great song ;)";
        video2._commentsList.Add(d3);

        Comment d4 = new Comment();
        d4._name = "Andrea";
        d4._text = "Find a better job";
        video2._commentsList.Add(d4);


        Video video3 = new Video();

        video3._title = "How to solve a 3x3 Rubik's cube - Beginner method";
        video3._author = "TheMaoiSha";
        video3._length = 621;

        Comment e1 = new Comment();
        e1._name = "Sara";
        e1._text = "Well explained!";
        video3._commentsList.Add(e1);

        Comment e2 = new Comment();
        e2._name = "Carlos";
        e2._text = "I don't even have a cube";
        video3._commentsList.Add(e2);

        Comment e3 = new Comment();
        e3._name = "Caroline";
        e3._text = "4x4 tutorial please";
        video3._commentsList.Add(e3);

        Comment e4 = new Comment();
        e4._name = "David";
        e4._text = "Any other methods?";
        video3._commentsList.Add(e4);

        Video[] videos = new Video[] {video1, video2, video3};

        foreach (Video v in videos)
        {
            Console.WriteLine($"Title: {v._title}");
            Console.WriteLine($"Author: {v._author}");
            Console.WriteLine($"Length: {v._length} seconds");
            Console.WriteLine($"Number of comments: {v.CommentsNumber()}");
            foreach (Comment com in v._commentsList)
            {
                Console.WriteLine($"{com._name}: {com._text}");
            }
            Console.WriteLine();
        }
    }
}