using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Transform> asteroidTransforms;
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public Transform bombsTransform;

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
    }

    //Create a method in the script

    public void SpawnBombAtOffSet(Vector3 inOffset)
    {
        Instantiate(bombPrefab, transform.position + inOffset, Quaternion.identity);
        
    }

}
