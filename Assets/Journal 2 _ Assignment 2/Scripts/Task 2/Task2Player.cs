using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System;
using UnityEngine.UIElements;

public class Task2Player : MonoBehaviour
{
    public GameObject bombPrefab;
    public Transform bombsTransform;

    public float distance;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            SpawnBombOnRandomCorner(distance);
        }
    }

    public void SpawnBombOnRandomCorner(float inDistance)
    {

        float length = (inDistance * inDistance) / Mathf.Sqrt(2);

        Vector2 pos = new Vector2(-length, +length);

        Instantiate(bombPrefab, pos, Quaternion.identity);

    }
}
