using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collider_detect_2 : MonoBehaviour
{
    static public bool collid = false;
    void OnCollisionStay2D(Collision2D other)
    {
        collid = true;
        Debug.Log("collid2=true");
    }
}
