using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimationController : MonoBehaviour
{
    Animator animator; 

    private void Start() {
        animator = GetComponent<Animator>();
    }

    public void PlayAnimation(float magnitude){
        if(magnitude > 0){
            animator.SetBool("Move", true);
        }else{
            animator.SetBool("Move", false);
        }
    }
}
