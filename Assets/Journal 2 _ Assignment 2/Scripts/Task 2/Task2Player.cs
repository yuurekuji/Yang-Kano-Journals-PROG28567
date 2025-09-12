using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using System;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class Task2Player : MonoBehaviour
{
    public GameObject bombPrefab;
    public Transform bombsTransform;

    public float distance;
    public Vector3[] corners = new Vector3[4];

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
        corners[0] = new Vector3(-1, 1, 0).normalized * inDistance;
        corners[1] = new Vector3(1, 1, 0).normalized * inDistance;
        corners[2] = new Vector3(1, -1, 0).normalized * inDistance;
        corners[3] = new Vector3(-1, -1, 0).normalized * inDistance;


        int randomNumber = Random.Range(0, 4);

        Vector3 spawnPos = transform.position + corners[randomNumber];

        Instantiate(bombPrefab, spawnPos, Quaternion.identity);



    }
}
