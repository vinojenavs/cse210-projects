using System;
using System.Security.Cryptography;
class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endverse;
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endverse = endVerse;
    }
    public static Reference createRange(string reference)
    {
        string[] parts = reference.Split(' ');
        string book = parts[0];
        string[] chapterVerse = parts[1].Split(':');
        int chapter = int.Parse(chapterVerse[0]);
        string[] verses = chapterVerse[1].Split('-');
        int verseStart = int.Parse(verses[0]);
        int verseEnd = int.Parse(verses[1]);
        return new Reference(book, chapter, verseStart, verseEnd);
    }
    public static Reference CreatSingle(string reference)
    {
        string[] parts = reference.Split(' ');
        string book = parts[0];
        string[] chapterVerse = parts[1].Split(':');
        int chapter = int.Parse(chapterVerse[0]);
        int verse = int.Parse(chapterVerse[1]);
        return new Reference(book, chapter, verse);
    }
    public override string ToString()
    {
        if (_endverse > 0)
        {
            return $"{_book} {_chapter}:{_verse}-{_endverse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}";
        }
    }
}