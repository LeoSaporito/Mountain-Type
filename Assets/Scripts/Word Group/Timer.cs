using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    [SerializeField] private WordGroup wordGroup;

    private void Update()
    {
        if (!wordGroup.startTimer)
        {
            return;
        }
        
        wordGroup.progressImage.fillAmount -= Time.deltaTime * wordGroup.timerSpeed;    
    }
}
