using NUnit.Framework.Internal;
using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class RowGeneration : MonoBehaviour
{
    public TMP_InputField inputs;

    string input;

    float row;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        input = inputs.text;
    

    }

    public void parsedinput()
    {
        Debug.Log(input);

    }
}
