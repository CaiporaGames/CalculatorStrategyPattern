using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class InsertValues : MonoBehaviour
{
    [SerializeField] SOEntries entries;


    string text;
    private void Start()
    {
        text = transform.GetChild(0).GetComponent<TextMeshPro>().text;
    }

    private void OnMouseDown()
    {
        if (entries.isEmpty)
        {
            entries.auxA += text;
            entries.a = Int32.Parse(entries.auxA);
        }
        else
        {
            entries.auxB += text;
            entries.b = Int32.Parse(entries.auxB);
        }
    }
}
