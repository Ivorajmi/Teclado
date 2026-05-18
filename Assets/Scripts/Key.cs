using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    void OnMouseDown(){
        Debug.Log("Click");
        transform.Translate(0,-1,0);
    }

    void OnMouseUp(){
        transform.Translate(0,1,0);
    }
}
