using TMPro;
using UnityEngine;

public class Word : MonoBehaviour
{
    [SerializeField] public string word;
    [SerializeField] private TextMeshProUGUI wordText;

    [SerializeField] private WordBank wordBank;
    [SerializeField] private LevelManager _levelManager;
    public WordsManager wordsManager;
    [SerializeField] private BoxCollider2D _boxCollider;

/*    private void Start()
    {
        GetNewWord();
    }*/
/*    private int RandomNumberGenerator()
    {
        int number = Random.Range(0, wordBank.wordVault.Count);

        return number;
    }*/
/*    public void GetNewWord()
    {
        word = wordBank.wordVault[RandomNumberGenerator()];
        wordText.text = word;
        //wordsManager.word = word;
    }*/
    public void ChangeTextColor(string answer)
    {
        if (answer == "green")
        {
            wordText.color = Color.green;
        }
        else if (answer == "red")
        {
            wordText.color = Color.red;
        }
        else if (answer == "white")
        {
            wordText.color = Color.white;
        }
    }
    public void MoveWord()
    {
        Bounds newPositionBounds = _boxCollider.bounds;
        float newPositionX = Random.Range(newPositionBounds.min.x, newPositionBounds.max.x);
        float newPositionY = Random.Range(newPositionBounds.min.y, newPositionBounds.max.y);

        transform.position = new Vector2(newPositionX, newPositionY);
    }
}
