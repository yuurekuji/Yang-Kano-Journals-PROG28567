using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using TMPro;
public class Player : MonoBehaviour
{
    public List<Transform> asteroidTransforms;
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public Transform bombsTransform;
    public TMP_InputField input;

    void Update()
    {
    

        Vector2 pos = transform.position;

        if(Input.GetKey(KeyCode.A))
        {
            pos.x -=0.1f ;    
        }

        if (Input.GetKey(KeyCode.D))
        {
            pos.x += 0.1f ;
        }
        transform.position = pos;

        if (Input.GetKeyDown(KeyCode.B))
        {
            SpawnBombAtOffSet(Vector3.up);
        }

        // warp drive
        Vector2 startPos = transform.position;
        Vector2 enemyPos = enemyTransform.position;

        if (Input.GetKeyDown(KeyCode.N))
        {
            WarpDrive(enemyPos-startPos);
        }


    }

    //Create a method in the script

    public void SpawnBombAtOffSet(Vector3 inOffset)
    {
        Instantiate(bombPrefab, transform.position + inOffset, Quaternion.identity);
        
    }

    // warp drive

    public void WarpDrive(Vector2 direction)
    {
        string userinput = input.text;


        Vector2 pos = transform.position;

        if (float.TryParse(userinput, out float num) && num >= 0)
        {
            Debug.Log(num);
        }
        else
        {
            Debug.Log("Choose a actual number");
        }



        pos += direction.normalized * num;

        transform.position = pos;
        
    }
}
