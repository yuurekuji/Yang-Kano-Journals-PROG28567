using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using TMPro;

public class Task1Player : MonoBehaviour
{


    public GameObject bombPrefab;
    public Transform bombsTransform;


    public Vector2 bombOffset = new Vector2(0, 1);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.B))
        {
            SpawnBombAtOffSet(Vector3.up);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {

        }
    }

    // Create method for spawning a bomb at offset
    public void SpawnBombAtOffSet(Vector3 inOffset)
    {
        Instantiate(bombPrefab, transform.position + inOffset, Quaternion.identity);

    }
    
    // Create a method for spawning a trail of bombs

    public void SpawnBombTrail(float inBombSpacing, int inNumberOfBombs)
    {

    }


}
