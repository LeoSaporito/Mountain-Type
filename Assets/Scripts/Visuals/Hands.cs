using UnityEngine;

public class Hands : MonoBehaviour
{
    [SerializeField] private bool isRightHand;

    [SerializeField] private Animator rightAnimator;
    [SerializeField] private Animator leftAnimator;

    private void Start()
    {
        isRightHand = true;
    }
    public void MoveHands()
    {
        if (isRightHand)
        {
            rightAnimator.SetTrigger("RightClimbUp");
            leftAnimator.SetTrigger("LeftClimbDown");
            isRightHand = false;
        }
        else
        {
            rightAnimator.SetTrigger("RightClimbDown");
            leftAnimator.SetTrigger("LeftClimbUp");
            isRightHand = true;
        }
    }
    public void StumbleHands()
    {
        rightAnimator.SetTrigger("RightStumble");
        leftAnimator.SetTrigger("LeftStumble");
    }
    public void FallHands()
    {
        rightAnimator.SetTrigger("RightFall");
        leftAnimator.SetTrigger("LeftFall");
    }
}
