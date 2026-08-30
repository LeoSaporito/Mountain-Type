using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;

public class GameManager : MonoBehaviour
{
    [SerializeField] private ScorePanelUI _scorePanelUI;
    [SerializeField] private ReadInput _readInput;
    [SerializeField] private Hands _hands;

    public void GameOver()
    {
        _scorePanelUI.DisplayScorePanel();
        _readInput.TurnOffInteraction();
        _hands.FallHands();
    }
}
