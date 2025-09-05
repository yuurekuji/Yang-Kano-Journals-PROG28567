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

    string userinput;

    float row;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        userinput = inputs.text;
    

    }

    public void parsedinput()
    {

        if(int.TryParse(userinput, out int num))
        {
            Debug.Log(num);
        }
        else
        {
            Debug.Log("invalid");
        }

 

        for (int i = 0; i < num; i++)
        {
            Vector2 origin = new Vector2(i, 0);
            //Vector2 end = new Vector2(i, 1);

            Vector2 topleftcorner = new Vector2(origin.x - 0.5f, origin.y + 0.5f);
            Vector2 toprightcorner = new Vector2(origin.x + 0.5f, origin.y + 0.5f);
            Vector2 bottomleftcorner = new Vector2(origin.x - 0.5f, origin.y - 0.5f);
            Vector2 bottomrightcorner = new Vector2(origin.x + 0.5f, origin.y - 0.5f);

            //Debug.DrawLine(origin, end, Color.white, Mathf.Infinity);

            Debug.DrawLine(topleftcorner, toprightcorner, Color.white, Mathf.Infinity);
            Debug.DrawLine(topleftcorner, bottomleftcorner, Color.white, Mathf.Infinity);
            Debug.DrawLine(toprightcorner, bottomrightcorner, Color.white, Mathf.Infinity);
            Debug.DrawLine(bottomrightcorner, bottomleftcorner, Color.white, Mathf.Infinity);

        } 


    }
}
