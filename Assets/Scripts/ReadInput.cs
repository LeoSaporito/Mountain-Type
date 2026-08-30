using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ReadInput : MonoBehaviour
{
    private string input;

    public TMP_InputField inputField;
    public WordManager wordManager;

    private void Start()
    {
        FocusOnInputField();
    }
    private void Update()
    {
        if(inputField.isFocused && (Input.GetKeyDown(KeyCode.Return) || Input.GetKeyDown(KeyCode.KeypadEnter)))
        {
            SubmitInput();
        }
    }
    private void SubmitInput()
    {
        string input = inputField.text;

        if (string.IsNullOrWhiteSpace(input)) { return; }

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
