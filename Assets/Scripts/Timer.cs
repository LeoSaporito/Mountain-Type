using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private float progress;
    [SerializeField] public float duration;

    [SerializeField] public float timerSpeed;

    [SerializeField] private Image progressImage;
    [SerializeField] private bool startTimer;

    [SerializeField] private GameManager _gameManager;

    private void Update()
    {
        if (progressImage.fillAmount <= 0)
        {
            _gameManager.GameOver();
            return;
        }
        if (!startTimer)
        {
            progressImage.fillAmount = progressImage.fillAmount;
        }
        else
        {
            progressImage.fillAmount -= Time.deltaTime * timerSpeed;    
        }
    }
    public void StartTimer()
    {
        startTimer = true;
    }
    public void StopTimer()
    {
        startTimer = false;        
    }
    public void ResetTimer()
    {
        progressImage.fillAmount = 1;
    }
    public void ChangeTimerColor(string answer)
    {
        if (answer == "green")
        {
            progressImage.color = Color.green;
        }
        else if (answer == "red")
        {
            progressImage.color = Color.red;
        }
        else if (answer == "white")
        {
            progressImage.color = Color.white;
        }
    }
}
