using JetBrains.Annotations;
using System.Collections.Generic;

using Unity.VisualScripting;
using UnityEngine;

public class TrigExcerise : MonoBehaviour
{

    public List<float> AnglesInDegrees = new List<float>();
    public int CurrentIndex = 0;
    public int radius = 1;
    public Vector3 circlePos;
    public float time = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //for (int i = 0; i < AnglesInDegrees.Count; i++)
        //{
        //    float degrees = AnglesInDegrees[i];
        //    float radians = degrees * Mathf.Deg2Rad;


        //    float x = Mathf.Cos(radians);
        //    float y = Mathf.Sin(radians);

        //    Vector3 point = new Vector3(x, y, 0) * radius + circlePos;



        //    Debug.DrawLine(circlePos, point, Color.white);

        //    if (i >= AnglesInDegrees.Count)
        //    {
        //        i = 0;

        //    }
        //}
    }
}
