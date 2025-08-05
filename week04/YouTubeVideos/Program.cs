using System;

class Program
{
    static void Main(string[] args)
    {
        List<Video> _videos = new List<Video>();
        Video video1 = new Video("How to play chess like a Grandmaster", "GothamChess", 923);
        video1.AddComment(new Comment("ChessFan123", "I like how he analyzed Gukesh game against Magnus Carlsen in the second part of the video"));
        video1.AddComment(new Comment("Amanda steel", "I wish i could see like 3 moves ahead. All i do is blunder my queen"));
        video1.AddComment(new Comment("OluwaTobi Frank", "Gukesh beat the goat of chess. Lol, do i smell a new bestplayer."));
        video1.AddComment(new Comment("Arthur the great", "Can you do an analysis video of Hikaru Nakamura vs Ding Liren championship match?"));
        _videos.Add(video1);

        Video video2 = new Video("How to prepare Owo soup", "Elo's Kitchen", 363);
        video2.AddComment(new Comment("Chinedu001", "I tried this once, Total disaster. It's way harder than it looks"));
        video2.AddComment(new Comment("Okoli Paul", "It blew my mind when i found out the basic ingredient of this dish is garri"));
        video2.AddComment(new Comment("George stew", "I'm American and my wife made this once but it looked nothing like the one in the video."));
        _videos.Add(video2);

        Video video3 = new Video("Why Ronaldo's the goat", "RealMadridFan", 1540);
        video3.AddComment(new Comment("Steven Grey", "Ronaldo dominated every league he went to. He's for sure the goat"));
        video3.AddComment(new Comment("IKnowFootball", "Until Ronaldo can score 91 goals ina calender year don't compare him to messi"));
        video3.AddComment(new Comment("Tunde Christian", "Messi fans would always disagree but Ronaldo is unmatched"));
        video3.AddComment(new Comment("Stacy Allen", "I always love a good CR7 and messi debate."));
        _videos.Add(video3);

        Video video4 = new Video("How to fix Iphone15 backglass", "No 1 Technician", 2456);
        video4.AddComment(new Comment("Austin", "How much would it cost to swap my Iphone 15 to an Iphone 16"));
        video4.AddComment(new Comment("Faith Ngozi", "Can you do a video on how to fix an iphone 16 touchpad"));
        video4.AddComment(new Comment("stephen phonemaster", "thanks i found this video very helpful"));
        _videos.Add(video4);

        foreach (var video in _videos)
        {
            Console.WriteLine("Title: " + video._title);
            Console.WriteLine("Author: " + video._author);
            Console.WriteLine("Videolength: " + video._videoLength + "secs");
            Console.WriteLine("Number of Comments:" + video.CommentCount());
            Console.WriteLine("Comments: ");
            foreach (var comment in video.GetComments())
            {
                Console.WriteLine($"- {comment._commenterName}: {comment._text}");
            }
            Console.WriteLine();
        }

    }
}