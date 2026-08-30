using UnityEngine;
using System.Collections;
using UnityEngine.LightTransport;
using UnityEngine.XR;

public class WordManager : MonoBehaviour
{
    public WordGroup[] wordGroups;
    [HideInInspector]public RightOrWrong rightOrWrong;

    public GameManager gameManager;
    public LevelManager _levelManager;

    public void CompareWords(string wordTyped)
    {
        foreach (WordGroup wordGroup in wordGroups)
        {
            if (wordTyped.ToLower() == wordGroup.word.ToLower())
            {
                // SUCCEEDED
                rightOrWrong.Correct(wordTyped, wordGroup);

                _levelManager.AddWord(wordTyped, "green");
                _levelManager.correct++;
                return;
            }
        }

        if(wordTyped != wordGroups[wordGroups.Length - 1].word)
        {
            // FAILED
            foreach (WordGroup wordGroup in wordGroups)
            {
                rightOrWrong.Incorrect(wordTyped, wordGroup);
            }

            _levelManager.AddWord(wordTyped, "red");
            _levelManager.incorrect++;
        }
    }
    public void GameOver(WordGroup failedWordGroup)
    {
        failedWordGroup.durationImage.color = Color.darkRed;
        failedWordGroup.wordText.color = Color.red;

        foreach (WordGroup wordGroup in wordGroups) 
        {
            wordGroup.startTimer = false;
        }

        gameManager.GameOver();
    }
}
