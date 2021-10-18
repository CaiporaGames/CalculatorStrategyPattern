using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OperationResult : MonoBehaviour
{
    [SerializeField] SOEntries entries;
    [SerializeField] TextMeshPro displayPanel;  


    private void OnMouseDown()
    {
        int result = entries.op.Calculator(entries.a, entries.b);
        entries.a = result;
        entries.b = 0;
        displayPanel.text = result.ToString();
        entries.auxA = "";
        entries.auxB = "";
    }
}
