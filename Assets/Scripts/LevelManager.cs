using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public static LevelManager instance;
    public SwitchController switchController;
    public DoorController   doorController;
    public KeyController    keyController;
    public bool hasKey;
    void Awake()
    {
        instance = this;
        hasKey = false;
    }

}
