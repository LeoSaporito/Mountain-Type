using UnityEngine;


public class WordsManager : MonoBehaviour
{
    //[SerializeField] private
    [SerializeField] private Hands _hands;
    [SerializeField] private Word _word;
    [SerializeField] private BackgroundScroller _backgroundScroller;
    [SerializeField] private Timer _timer;
    [SerializeField] private LevelManager _levelManager;
    //[SerializeField] public string word;
    [SerializeField] public GameObject[] wordsObj;

    public void CompareWords(string wordTyped)
    {
        for (int i = 0; i < wordsObj.Length; i++)
        {
            string word = wordsObj[i].GetComponent<Word>().word;

            if (wordTyped.ToLower() == word)
            {
                //SUCEEDED
                Correct(wordTyped, wordsObj[i]);
                return;
            }
            else if (wordTyped.ToLower() != word && i == wordsObj.Length - 1)
            {
                //FAILED
                Incorrect(wordTyped, wordsObj[i]);                
            }
        }
        
        _levelManager.attempts++;

    /*        if (wordTyped.ToLower() != word)
        {
            //FAILED
            _levelManager.AddWord(wordTyped, "red");
            StartCoroutine(IncorrectUpdate());
        }
        else
        {
            //SUCEEDED
            _levelManager.AddWord(wordTyped, "green");
            StartCoroutine(CorrectUpdate());
        }
*/
    }
    public void Correct(string wordTyped, GameObject wordObj)
    {
        _levelManager.AddWord(wordTyped, "green");
        StartCoroutine(wordObj.GetComponent<WordCompare>().CorrectUpdate());

        _backgroundScroller.ScrollUp();

        _hands.MoveHands();

        _levelManager.correct++;
    }
    public void Incorrect(string wordTyped, GameObject wordObj)
    {
        _levelManager.AddWord(wordTyped, "red");
        StartCoroutine(wordObj.GetComponent<WordCompare>().IncorrectUpdate());

        _backgroundScroller.ScrollDown();

        _hands.StumbleHands();

        _levelManager.incorrect++;
    }
}
