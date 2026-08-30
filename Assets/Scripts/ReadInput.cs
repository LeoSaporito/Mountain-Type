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
    public void ReadStringInput(string s)
    {
        input = s;

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
