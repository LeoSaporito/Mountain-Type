using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScorePanelUI : MonoBehaviour
{
    [SerializeField] private LevelManager _levelManager;
    //[SerializeField] private TextMeshProUGUI wordsTyped;
    [SerializeField] private GameObject word;
    [SerializeField] private GameObject wordGroup;
    [SerializeField] private TextMeshProUGUI correctText;
    [SerializeField] private TextMeshProUGUI incorrectText;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI highScoreText;

    [SerializeField] private bool hasTriggered;

    private void Start()
    {
        this.gameObject.SetActive(false);        
    }
    public void DisplayScorePanel()
    {
        if (!hasTriggered)
        {
            this.gameObject.SetActive(true);

            AddWord();

            correctText.text = "Correctly Spelled: " + _levelManager.correct;
            incorrectText.text = "Incorrectly Spelled: " + _levelManager.incorrect;
            scoreText.text = _levelManager.correct + " - " + _levelManager.incorrect + " = " + _levelManager.score;
            highScoreText.text = "Highest Score: " + _levelManager.highestScore;

            hasTriggered = true;
        }
    }
    public void AddWord()
    {
        for (int i = 0; i < _levelManager.wordsTyped.Count; i++)
        {
            GameObject wordAdded = Instantiate(word, wordGroup.transform.position, Quaternion.identity, wordGroup.transform);

            TextMeshProUGUI wordsTyped = wordAdded.GetComponent<TextMeshProUGUI>();

            wordsTyped.text = _levelManager.wordsTyped[i];

            if (_levelManager.wordTypedColor[i] == "green")
            {
                wordsTyped.color = Color.green;
            }
            else
            {
                wordsTyped.color = Color.red;
            }
        }
    }
}
