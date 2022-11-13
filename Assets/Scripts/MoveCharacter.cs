using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCharacter : MonoBehaviour
{
    public Animator anim;
    public void Walk()
    {
        //anim.SetTrigger("Move");
        anim.SetBool("Walk", true);
    }
}
