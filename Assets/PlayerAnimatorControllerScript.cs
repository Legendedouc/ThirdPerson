using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using CMF;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class PlayerAnimatorControllerScript : MonoBehaviour
{
    private Animator anim;
    private AdvancedWalkerController walkerController;
    public CharacterKeyboardInput keyInput;
    // Start is called before the first frame update
    void Start()
    {
        anim.CrossFade("Idle",0,0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     
        //Character Animator Controller
        switch(keyInput.GetHorizontalMovementInput(), keyInput.GetVerticalMovementInput(),walkerController.IsGrounded())
        {
            case (0,0,true):
                activateAnimation("isIdle");
                break;
            case (0,1,true):
                activateAnimation("isRunForward");
                break;
            case (-1,0,true):
                  activateAnimation("isStrafeLeft");
                  break; 
            case (1,0,true):
                  activateAnimation("isStrafeRight");
                  break;
            case (1,1,true):
                  activateAnimation("isRunLeft");
                  break;
            case (-1,1,true):
                  activateAnimation("isRunRight");
                  break;
              
            case (0,-1,true):
                  anim.CrossFade("RunBackward", 0, 0);
                  break;
            case (-1,-1,true):
                  anim.CrossFade("RunBackwardLeft", 0, 0);
                  break;
            case (1,-1,true):
                  anim.CrossFade("RunBackwardRight", 0, 0);
                  break;
        }
      
    }
    
    void Awake()
    {
       anim = this.GetComponent<Animator>();
       keyInput = this.GetComponentInParent<CharacterKeyboardInput>();
       walkerController = GetComponentInParent<AdvancedWalkerController>();
    }

    void activateAnimation(string stateName)
    {
        anim.SetBool("isIdle",false);
        anim.SetBool("isRunForward",false);
        anim.SetBool("isRunLeft",false);
        anim.SetBool("isRunRight",false);
        anim.SetBool("isStrafeLeft",false);
        anim.SetBool("isStrafeRight",false);
        anim.SetBool(stateName,true);
    }    
    #region Cached Properties

    private int _currentState;

    private static readonly int Idle = Animator.StringToHash("StrafeLeft");
    private static readonly int Walk = Animator.StringToHash("Walk");
    private static readonly int Jump = Animator.StringToHash("Jump");
    private static readonly int Fall = Animator.StringToHash("Fall");
    private static readonly int Land = Animator.StringToHash("Land");
    private static readonly int Attack = Animator.StringToHash("Attack");
    private static readonly int Crouch = Animator.StringToHash("Crouch");
    private static readonly int IsMoving = Animator.StringToHash("isMoving");

    #endregion

}
