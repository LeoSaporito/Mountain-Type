using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ReadInput : MonoBehaviour
{
    public TMP_InputField inputField;
    public WordManager wordManager;

    public GameObject tutorialText;

    private void Start()
    {
        FocusOnInputField();
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            SubmitInput();
        }
    }
    private void SubmitInput()
    {
        string input = inputField.text;
        print(input);

        if (string.IsNullOrWhiteSpace(input)) { return; }

        if(tutorialText.activeSelf) { tutorialText.SetActive(false); }

        wordManager.CompareWords(input);
        inputField.text = "";
        FocusOnInputField();
    }
    public void FocusOnInputField()
    {
        EventSystem.current.SetSelectedGameObject(inputField.gameObject);
        inputField.ActivateInputField();
    }
    public void TurnOffInteraction()
    {
        inputField.interactable = false;
    }
}
