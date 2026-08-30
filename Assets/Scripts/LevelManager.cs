using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] public List<string> wordsTyped = new List<string>();
    [SerializeField] public List<string> wordTypedColor = new List<string>();
    [SerializeField] public int correct;
    [SerializeField] public int incorrect;
    [SerializeField] public int score;
    [SerializeField] public int highestScore;
    [SerializeField] public int attempts;

    public void AddWord(string word, string color)
    {
        wordsTyped.Add(word);
        wordTypedColor.Add(color);
    }
    private void Update()
    {
        score = correct - incorrect;

        if (score > highestScore)
        {
            highestScore = score;
        }
    }
}
