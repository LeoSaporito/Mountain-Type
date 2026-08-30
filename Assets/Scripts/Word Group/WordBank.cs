using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;

public class WordBank : MonoBehaviour
{
    public List<string> wordVault = new List<string>();

    private void Start()
    {
        AddToWordVault(EasyWords());
    }
    public string GetWord()
    {
        //pick a random number between 0 and the length of the word vault
        int randomNumber = Random.Range(0, wordVault.Count);

        //get the word at that index
        string word = wordVault[randomNumber - 1];

        //remove the word from the vault so it can't be used again
        wordVault.RemoveAt(randomNumber - 1);

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
    public string[] EasyWords()
    {
        string[] words = new string[] {"cat", "van", "horn", "pet", "rock", "rep", "lean", "pot", "key", "ten", "one", "two", "hill", "fin", "yarn", "tin", "net", "hot", "fill", "card", "lens", "dip"};

        return words;
    }
    public string[] HardWords()
    {
        string[] words = new string[] {"ratio", "mince", "crypt", "drink", "burns", "lunch", "lunge", "crisp", "world", "hello", "slide", "freak", "sorry", "toned", "strong", "dance", "curse"};

        return words;
    }
}
