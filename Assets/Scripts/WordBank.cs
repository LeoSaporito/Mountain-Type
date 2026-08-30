using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using System.Collections.Generic;

public class WordBank : MonoBehaviour
{
    [SerializeField] public List<string> wordVault = new List<string>();

    private void Awake()
    {
        AddToWordVault(EasyWords());
    }
    public void AddToWordVault(string[] words)
    {
        for (int i = 0; i < words.Length; i++)
        {
            wordVault.Add(words[i]);
        }
    }

    private string[] EasyWords()
    {
        string[] words = new string[] {"cat", "van", "horn", "pet", "rock", "rep", "lean", "pot", "key", "ten", "one", "two", "hill", "fin", "yarn", "tin", "net", "hot", "fill", "card", "lens", "dip"};

        return words;
    }
    private string[] HardWords()
    {
        string[] words = new string[] {"ratio", "mince", "crypt", "drink", "burns", "lunch", "lunge", "crisp", "world", "hello", "slide", "freak", "sorry", "toned", "strong", "dance", "curse"};

        return words;
    }
}
