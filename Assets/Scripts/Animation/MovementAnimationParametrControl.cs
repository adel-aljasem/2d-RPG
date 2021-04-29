using UnityEngine;

public class MovementAnimationParametrControl : MonoBehaviour
{
    private Animator animatior;

    private void Awake()
    {
        animatior = GetComponent<Animator>();
    }

    private void OnEnable()
    {
        EventHandler.MovementEvent += SetAnimationParameters;
    }

    private void OnDisable()
    {
        EventHandler.MovementEvent -= SetAnimationParameters;
    }

    private void SetAnimationParameters(float inputX, float inputY, bool isWalking, bool isRunning, bool isIdle, bool isCarrying, ToolEffect toolEffect,
    bool isUsingTollRight, bool isUsingToolLeft, bool isUsingToolUp, bool isUsingToolDown,
    bool isLifingToolRight, bool isLiftingToolLeft, bool isLiftingToolUp, bool isLiftingToolDown,
    bool isPickingRight, bool isPickingLeft, bool isPickingUp, bool isPickingDown,
    bool isSwingingToolRight, bool isSwingingToolLeft, bool isSwingingToolUp, bool isSwingingToolDown,
    bool idleUp, bool idleDown, bool idleLeft, bool idleRight)
    {
        animatior.SetFloat(Settings.xInput, inputX);
        animatior.SetFloat(Settings.yInput,inputY);
        animatior.SetBool(Settings.isWalking,isWalking);
        animatior.SetBool(Settings.isRunning, isRunning);

        animatior.SetInteger(Settings.toolEffect, (int)toolEffect);

        if (isUsingTollRight)
        {
            animatior.SetTrigger(Settings.isUsingToolRight);
        }
        if (isUsingToolLeft)
        {
            animatior.SetTrigger(Settings.isUsingToolLeft);
        }
        if (isUsingToolUp)
        {
            animatior.SetTrigger(Settings.isUsingToolUp);
        }
        if (isUsingToolDown)
        {
            animatior.SetTrigger(Settings.isUsingToolDown);
        }

        if (isLifingToolRight)
        {
            animatior.SetTrigger(Settings.isLiftingToolRight);
        }
        if (isLiftingToolLeft)
        {
            animatior.SetTrigger(Settings.isLiftingToolLeft);
        }
        if (isLiftingToolUp)
        {
            animatior.SetTrigger(Settings.isLiftingToolUp);
        }
        if (isLiftingToolDown)
        {
            animatior.SetTrigger(Settings.isLiftingToolDown);
        }

        if (isSwingingToolRight)
        {
            animatior.SetTrigger(Settings.isSwingingToolRight);
        }
        if (isSwingingToolLeft)
        {
            animatior.SetTrigger(Settings.isSwingingToolLeft);
        }
        if (isSwingingToolUp)
        {
            animatior.SetTrigger(Settings.isSwingingToolUp);
        }
        if (isSwingingToolDown)
        {
            animatior.SetTrigger(Settings.isSwingingToolDown);
        }

        if (isPickingRight)
        {
            animatior.SetTrigger(Settings.isPickingRight);
        }
        if (isPickingLeft)
        {
            animatior.SetTrigger(Settings.isPickingLeft);
        }
        if (isPickingUp)
        {
            animatior.SetTrigger(Settings.isPickingUp);
        }
        if (isPickingDown)
        {
            animatior.SetTrigger(Settings.isPickingDown);
        }

        if (idleRight)
        {
            animatior.SetTrigger(Settings.idleRight);
        }
        if (idleLeft)
        {
            animatior.SetTrigger(Settings.idleLeft);
        }
        if (idleUp)
        {
            animatior.SetTrigger(Settings.idleUp);
        }
        if (idleDown)
        {
            animatior.SetTrigger(Settings.idleDown);
        }




    }


    private void AnimationEventPlayFootstepSound()
    {

    }
}
