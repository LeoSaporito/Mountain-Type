using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScorePanelUI : MonoBehaviour
{
    [SerializeField] private LevelManager _levelManager;
    [SerializeField] private GameObject scorePanel;
    [SerializeField] private GameObject word;
    [SerializeField] private GameObject wordGroup;
    [SerializeField] private TextMeshProUGUI correctText;
    [SerializeField] private TextMeshProUGUI incorrectText;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;

    [SerializeField] private bool hasTriggered;

    private void Start()
    {
        scorePanel.SetActive(false);
        hasTriggered = false;
    }
    public void DisplayScorePanel()
    {
        scorePanel.SetActive(true);

        correctText.text = "Correctly Spelled: " + _levelManager.correct;
        incorrectText.text = "Incorrectly Spelled: " + _levelManager.incorrect;
        scoreText.text = "Final Score: " + _levelManager.correct + " - " + _levelManager.incorrect + " = " + _levelManager.score;
        highScoreText.text = "Highest Score: " + _levelManager.highestScore;
            
        hasTriggered = true;        
    }
    public void AddWord(string wordTyped, string color)
    {
        GameObject wordAdded = Instantiate(this.word, wordGroup.transform.position, Quaternion.identity, wordGroup.transform);

        TextMeshProUGUI wordAddedText = wordAdded.GetComponent<TextMeshProUGUI>();

        wordAddedText.text = wordTyped;

        if (color == "green")
        {
            wordAddedText.color = Color.green;
        }
        else
        {
            wordAddedText.color = Color.red;
        }        
    }
}
