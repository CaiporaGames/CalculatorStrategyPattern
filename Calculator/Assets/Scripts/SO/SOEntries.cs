using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Entries", menuName= "ScriptableObject / Entries")]
public class SOEntries : ScriptableObject
{
    public int a, b;//Parameters to the operators
    public bool isEmpty = true;//If we are filling the "a" parameter it is true otherwise, we are filling the b parameter it is false;
    public IOperator op = null;//Which operator is been used now
    public string auxA, auxB;//Used in each number button to hold multiple characters

    private void OnEnable()
    {
        a = 0;
        b = 0;
        auxA = "";
        auxB = "";
        isEmpty = true;
    }
}
