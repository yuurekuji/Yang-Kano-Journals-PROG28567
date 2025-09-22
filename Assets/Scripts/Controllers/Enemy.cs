using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour
{

    public Transform player;
    public float speed = 3f;
    public float maxSpeed = 10;
    public float accelerationTime = 2;
    public float acceleration;
    public float minDist = 4;

    private void Start()
    {

        acceleration = maxSpeed / accelerationTime;
    }
    private void Update()
    {

        enemyMovement();
        
    }

    public void enemyMovement()
    {
        Vector3 playerDirection = player.position;
        transform.position = Vector2.MoveTowards(transform.position, playerDirection, speed * acceleration * Time.deltaTime);
    }

   

}
