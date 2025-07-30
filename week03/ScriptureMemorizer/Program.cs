using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = Reference.CreatSingle("1Nephi 3:7");
        string text = "And it came to pass that I, Nephi said unto my father: I will go and do the things which the Lord hath commanded, for I know the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them";

        Scripture scripture = new Scripture(reference, text);
        while (true)
        {
            Console.Clear();
            scripture.Display();
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
            Console.WriteLine("Press enter to continue or type 'quit' to finish");
            string input = Console.ReadLine();
            if (input.ToLower() == "quit")
            {
                break;
            }
            Console.Clear();
            scripture.HideRandomWords(3);
        }
    }
}