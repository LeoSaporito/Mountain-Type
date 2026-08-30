using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] public int correct;
    [SerializeField] public int incorrect;
    [SerializeField] public int score;
    [SerializeField] public int highestScore;
    [SerializeField] public int attempts;

    public ScorePanelUI _scorePanelUI;

    public void AddWord(string word, string color)
    {
        _scorePanelUI.AddWord(word, color);
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
