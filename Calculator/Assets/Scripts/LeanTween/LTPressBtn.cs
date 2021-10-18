using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LTPressBtn : MonoBehaviour
{
    // Start is called before the first frame update
    void OnMouseDown()
    {
        LeanTween.moveY(gameObject, -0.01f, 0.5f).setEasePunch();
    }   
}
