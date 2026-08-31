using System.Collections.Generic;
using UnityEditor.Animations;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField] public int correct;
    [SerializeField] public int incorrect;
    [SerializeField] public int score;
    [SerializeField] public int highestScore;
    [SerializeField] public int attempts;

    public ScorePanelUI _scorePanelUI;

    [SerializeField] public GameObject[] wordGroups;

    [SerializeField] public int activeGroupIndex = 1;
    [SerializeField] public int increaseDifficulty = 10;

    private void Start()
    {
        for(int i = 1; i < wordGroups.Length; i++)
        {
            wordGroups[i].SetActive(false);
        }
    }
    public void AddWord(string word, string color)
    {
        _scorePanelUI.AddWord(word, color);
    }
    private void Update()
    {
        score = correct - incorrect;

        if(attempts > increaseDifficulty)
        {
            if(activeGroupIndex >= wordGroups.Length)
            {
                return;
            }

            wordGroups[activeGroupIndex].SetActive(true);
            wordGroups[activeGroupIndex].GetComponent<WordGroup>().startTimer = true;
        
            activeGroupIndex++;
            increaseDifficulty += 10;
        }
    }
    public void FinalScoreCheck()
    {
        if (score > highestScore)
        {
            highestScore = score;
        }
    }
}
