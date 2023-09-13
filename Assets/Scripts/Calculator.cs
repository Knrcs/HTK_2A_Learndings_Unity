using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Calculator : MonoBehaviour
{
    public TMP_InputField field01;
    public TMP_InputField field02;
    private int _value01;
    private int _value02;
    
    public void awawa()
    {
        Debug.Log("Bruh");
    }

    public void AddInts()
    {
        int.TryParse(field01.text, out _value01);
        int.TryParse(field02.text, out _value02);

        int sum = _value01 + _value02;
        
        Debug.Log(sum);
    }
}
