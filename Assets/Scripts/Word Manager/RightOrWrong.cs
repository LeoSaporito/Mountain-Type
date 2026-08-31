using UnityEngine;
using System.Collections;
using UnityEngine.LightTransport;
using UnityEngine.XR;

public class RightOrWrong : MonoBehaviour
{
    [Header("Scripts")]
    [SerializeField] private Hands _hands;
    [SerializeField] private BackgroundScroller _backgroundScroller;
    
    [Header("Coroutine")]
    [SerializeField] public float delay;

    //<<---------- Correct ---------->//
    public void Correct(string wordTyped, WordGroup wordGroup)
    {
        StartCoroutine(CorrectUpdate(wordGroup));

        _backgroundScroller.ScrollUp();
        _hands.MoveHands();
    }
    public IEnumerator CorrectUpdate(WordGroup wordGroup)
    {
        wordGroup.wordText.color = Color.green;
        wordGroup.progressImage.color = Color.green;
        wordGroup.startTimer = false;
        wordGroup.ChangeWord();

        yield return new WaitForSeconds(delay);

        wordGroup.DisplayWord();
        wordGroup.wordText.color = Color.white;
        wordGroup.progressImage.color = Color.white;
        wordGroup.progressImage.fillAmount = 1;
        wordGroup.startTimer = true;

        yield return null;
    }

    //<<---------- Incorrect ---------->//
    public void Incorrect(string wordTyped, WordGroup wordGroup)
    {
        StartCoroutine(IncorrectUpdate(wordGroup));

        _backgroundScroller.ScrollDown();
        _hands.StumbleHands();
    }
    public IEnumerator IncorrectUpdate(WordGroup wordGroup)
    {
        wordGroup.wordText.color = Color.red;
        wordGroup.progressImage.color = Color.red;

        yield return new WaitForSeconds(delay);

        wordGroup.wordText.color = Color.white;
        wordGroup.progressImage.color = Color.white;

        yield return null;
    }
}
