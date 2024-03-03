using System.Security.Cryptography;
using System.IO;

public class Scripture {
    public List<Word> words;
    Reference reference;

    public Scripture(string book, string chapter, string verses, string scripture) {
        this.reference = new Reference(book, chapter, verses);
        string[] rawWords = scripture.Split(" ");
        foreach(string word in rawWords) {
            words.Add(new Word(word));
            System.Console.WriteLine(new Word(word).GetWord());
        }
    }

    public void DisplayScripture() {
        System.Console.WriteLine(words.Count);
        foreach(Word word in words) {
            System.Console.Write(word.GetWord() + " ");
        }
    }

    public string Display() {
        return "Hi";
    }
}