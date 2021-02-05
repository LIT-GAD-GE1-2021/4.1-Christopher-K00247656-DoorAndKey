using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    private Animator DoorAnimator;
    public bool doorOpen;

    void Awake()
    {
        DoorAnimator = gameObject.GetComponent<Animator>();
        closed();
    }

    public void open()
    {
       
        DoorAnimator.SetBool("DoorOpen", true);
         doorOpen = true;
    }

    public void closed()
    {
        
        DoorAnimator.SetBool("DoorOpen", false);
        doorOpen = false;
    }
}
