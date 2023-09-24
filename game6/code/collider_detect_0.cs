using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider_detect_0 : MonoBehaviour
{
    static public bool collid = false;
    void OnCollisionStay2D(Collision2D other)
    {
        collid = true;
        Debug.Log("collid0=true");
    }
}
