using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinusOperator : MonoBehaviour, IOperator
{
    [SerializeField] SOEntries entries;

    public int Calculator(int a, int b)
    {
        return a - b;
    }

    private void OnMouseDown()
    {
        entries.op = this;
        entries.isEmpty = false;
    }
}
