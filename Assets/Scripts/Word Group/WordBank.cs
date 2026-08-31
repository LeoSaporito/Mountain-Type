using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;

public class WordBank : MonoBehaviour
{
    public List<string> wordVault = new List<string>();

    private void Awake()
    {
        AddToWordVault(Words());        
    }
    public string GetWord()
    {
        //pick a random number between 0 and the length of the word vault
        int randomNumber = Random.Range(0, wordVault.Count);

        //get the word at that index
        string word = wordVault[randomNumber];

        //remove the word from the vault so it can't be used again
        wordVault.RemoveAt(randomNumber);

        //return the word
        return word;
    }
    public void ReturnWord(string word)
    {
        //add the word back to the vault
        wordVault.Add(word);
    }
    public void AddToWordVault(string[] words)
    {
        for (int i = 0; i < words.Length; i++)
        {
            wordVault.Add(words[i]);
        }
    }
    public string[] Words()
    {
        string[] words = new string[] {"cat", "van", "horn", "pet", "rock", "rep", "lean", "pot", "key", "ten", "one", "two", "hill", "fin", "yarn", "tin", "net", "hot", "fill", "card", "lens", "dip", "tree", "rinse", "glow",
                                       "drop", "bottom", "mince", "ratio", "mince", "crypt", "drink", "burn", "lunch", "lunge", "crisp", "world", "hello", "slide", "freak", "sorry", "toned", "strong", "dance", "curse", "sick",
                                       "state", "great", "other", "galop", "last", "first", "public", "list", "green", "fern", "fact", "lead", "turn", "well", "other", "could", "cough", "real", "large", "paper", "leg", "adult",
                                       "eye", "she", "mean", "make", "turn", "over", "night", "many", "also", "that", "hand", "should", "no", "yes", "see", "long", "hunch", "dense", "trope", "fed", "the", "and", "but", "swim",
                                       "type", "key", "board", "any", "for", "earn", "game", "okay", "fun", "dead", "trip", "trunk", "lost", "win", "toy", "we", "zen", "slider", "small", "large", "night", "late", "or", "soon",
                                       "early", "time", "hair", "shave", "sunny", "days", "bar", "bottle", "flip", "front", "back", "heal", "hope", "hurt", "buns", "fled", "post", "rip", "cone", "bark", "stump", "char", "full",
                                       "mop", "fear", "rich", "poor", "doing", "lace", "tuck", "guys", "shy", "shine", "this", "thank", "son", "load", "me", "little", "climb", "sword", "space", "grand", "great", "done", "felt",
                                       "talk", "bet", "dice", "cards", "out", "just", "like", "that", "main", "theme", "if", "then", "else", "when", "where", "why", "how", "user", "pause", "brine", "four", "five", "spike", "word",
                                       "six", "seven", "eight", "nine", "ball", "high", "info", "down", "bird", "you", "buy", "bye", "by", "cut", "but", "can", "know", "before", "met", "dont", "take", "bad", "free", "so", "case",
                                       "bull", "fact", "there", "their", "tree", "gross", "moon", "drop", "charm", "fix", "die", "rise", "real", "tale", "real", "good", "form", "like", "best", "frame", "will", "live", "with", "it",
                                       "leads", "may", "pint", "get", "split", "up", "join", "here", "did", "mind", "need", "some", "thing", "ruby", "iron", "sand", "wrong", "ridge", "us", "mag", "stock", "aim", "home", "usher",
                                       "self", "build", "hood", "all", "a", "say", "do", "at", "too", "new", "focus", "atom", "order", "shine", "wire", "cook", "queen", "mixed", "fluid", "sort", "kick", "point", "top", "off", "on",
                                       "crow", "year", "hour", "slice", "junk", "ice", "red", "bus", "mud", "bin", "flat", "den", "nag", "keg", "our", "bat", "add", "lot", "jam", "bag", "map", "tap", "bed", "mine", "clap", "claw",
                                       "nose", "bond", "tall", "rise", "hen", "tail", "dress", "shoes", "i", "nifty", "neat", "clever", "look", "are", "of", "is", "an", "has", "in", "quiet", "room", "were", "use", "such", "as",
                                       "very", "your", "does", "more", "leak", "to", "exit", "hang", "want", "move", "sky", "crow", "lamp", "evil", "keep", "rest", "until", "into", "open", "prop", "among", "sent", "drip", "soap",
                                       "farm", "glad", "fly", "hid", "job", "kiwi", "least", "zip", "zoom", "zone", "zest", "mix", "axe", "tax", "pixel", "text", "fox", "hoax", "cram", "close", "vent", "vest", "vine", "vase",
                                       "nail", "need", "north", "mist", "mat", "quick", "quiz", "quest", "quit", "quip", "odd", "gone", "push", "worn", "rain", "gun", "legal", "sun", "pour", "who", "scuba", "doom", "ton", "moss"};

        return words;
    }
}
