using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System;
using UnityEngine.UIElements;
using UnityEditor;

public class Task5Player : MonoBehaviour
{

    public List<Transform> asteroids  = new List<Transform>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            DetectAsteroids(30, asteroids);
        }
    }

    public void DetectAsteroids(float inMaxRange, List<Transform> inAsteroids)
    {
        for(int i = 0; i  < inAsteroids.Count; i++)
        {

            Vector2 asteroidPos = inAsteroids[i].position;

            Debug.DrawLine(asteroidPos, transform.position, Color.white, 5);

        }
        
    }

}
