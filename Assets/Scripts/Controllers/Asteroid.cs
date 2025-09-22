using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using Random = UnityEngine.Random;

public class Asteroid : MonoBehaviour
{
    public float moveSpeed;
    public float arrivalDistance;
    public float maxFloatDistance;

    Vector3 Velocity = new Vector3(0,0,0);



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        asteroidMovement();
    }

    public void asteroidMovement()
    {

        float randomX = Random.Range(-1.0f, 1.0f);
        float randomY = Random.Range(-1.0f, 1.0f);

        Debug.Log(randomX);
        Debug.Log(randomY);
        Vector3 direction = new Vector3(randomX, randomY, 0);

        float DistanceBetween = Vector3.Distance(transform.position, direction);

        float distanceCovered = Time.deltaTime * moveSpeed;
        direction = direction.normalized * maxFloatDistance;
       
        Vector3 interpol = Vector3.Lerp(transform.position, direction, distanceCovered / DistanceBetween);

        transform.position += interpol*Time.deltaTime;
    }

}
