using UnityEngine;
using UnityEngine.EventSystems;
using TMPro;

public class ReadInput : MonoBehaviour
{
    private string input;
    public TMP_InputField inputField;
    public WordsManager wordsManager;
    private void Start()
    {
        inputField.Select();
    }
    private void Update()
    {
        if (EventSystem.current.currentSelectedGameObject != inputField)
        {
            FocusOnInputField();
        }
    }
    public void ReadStringInput(string s)
    {
        input = s;

        wordsManager.CompareWords(input);

        inputField.text = null;

        FocusOnInputField();
    }
    public void FocusOnInputField()
    {
        inputField.ActivateInputField();
        inputField.Select();
    }
    public void TurnOffInteraction()
    {
        inputField.interactable = false;
    }
}
