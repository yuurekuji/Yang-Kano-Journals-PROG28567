using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;
using Unity.VisualScripting;
public class Player : MonoBehaviour
{
    public List<Transform> asteroidTransforms;
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public Transform bombsTransform;
    public TMP_InputField input;

    public float speed = 3f;
    public float maxSpeed = 2;
    public float accelerationTime = 4;
    public float acceleration;

    Vector3 velocity = new Vector3(0, 0, 0);


    private void Start()
    {
        acceleration = maxSpeed / accelerationTime;
    }
    void Update()
    {


        playerMovement();
        Debug.Log(velocity.x);










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
    public void playerMovement()
    {

        Vector3 direction = Vector3.zero;
        
        // Key down
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction += Vector3.left;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction += Vector3.right;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            direction += Vector3.down;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            direction += Vector3.up;
        }

        // when the key is released
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {

        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {

        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {

        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {

        }


        direction = direction.normalized;
        velocity += direction * acceleration * Time.deltaTime;
        transform.position += velocity;


        if(velocity.x >= maxSpeed)
        {
            velocity.x = maxSpeed;
        }
        else if(velocity.x <= -maxSpeed)
        {
            velocity.x = -maxSpeed;
        }

        if (velocity.y >= maxSpeed)
        {
            velocity.y = maxSpeed;
        }
        else if( velocity.y <= -maxSpeed)
        {
            velocity.y = -maxSpeed;
        }



    }
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
