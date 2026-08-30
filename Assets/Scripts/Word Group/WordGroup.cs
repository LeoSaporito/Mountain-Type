using System.Collections.Generic;
using System.Security.Cryptography;
using TMPro;
using UnityEngine;
using UnityEngine.LightTransport;
using UnityEngine.UI;

public class WordGroup : MonoBehaviour
{
    [Header("Word Settings")]
    public TextMeshProUGUI wordText;
    public string word;

    [Header("Timer Settings")]
    public Image progressImage;
    public Image durationImage;
    public float timerSpeed;
    public bool startTimer;

/*    [Header("Child Scripts")]
    [SerializeField] private WordText wordText;
    [SerializeField] private WordBank wordBank;*/
    [HideInInspector] public WordText _wordText;
    [HideInInspector] public WordBank _wordBank;
    [HideInInspector] public WordManager _wordManager;

    private bool gameOver;

    private void Start()
    {
        InitializeScripts();

        NewWord();
        DisplayWord();

        gameOver = false;
    }
    private void InitializeScripts()
    {
        _wordText = GetComponentInChildren<WordText>();
        _wordBank = GetComponentInParent<WordBank>();
        _wordManager = GetComponentInParent<WordManager>();
    }
    public void ChangeWord()
    {
        // Return the current word to the word bank
        _wordBank.ReturnWord(word);
        word = null;

        NewWord();
    }
    public void NewWord()
    {
        // Get a new word from the word bank
        word = _wordBank.GetWord();
    }
    public void DisplayWord()
    {
        // Display the word in the text component
        wordText.text = word;
    }
    private void Update()
    {
        if (progressImage.fillAmount <= 0 && !gameOver)
        {
            gameOver = true;
            _wordManager.GameOver(this);
        }
    }
}
