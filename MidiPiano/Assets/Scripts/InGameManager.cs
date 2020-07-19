using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class InGameManager : MonoBehaviour
{
    private static InGameManager s_instance = null;
    public static InGameManager instance
    {
        get
        {
            s_instance = FindObjectOfType(typeof(InGameManager)) as InGameManager;
            return (s_instance != null) ? s_instance : null;
        }
    }

    public TriggerSpriteAnimation triggerAni;
    

}
