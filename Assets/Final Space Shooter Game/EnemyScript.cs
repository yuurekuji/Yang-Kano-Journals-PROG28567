using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;


public class EnemyScript : MonoBehaviour
{
    public List<float> AnglesInDegrees = new List<float>();
    public List<Vector3> Points = new List<Vector3>();

    public int CurrentIndex = 0;
    public float DetectionRadius;
    public float DamageRadius;

    public Vector3 Enemy;

    public int life;
    public float movingSpeed;

    public Transform Player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Enemy = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        EnemyDetection();
        DamageDetection();
    }
    public void EnemyDetection()
    {
        Color col = Color.green;

        for (int i = 0; i < AnglesInDegrees.Count; i++)
        {
            float degrees = AnglesInDegrees[i];
            float radians = degrees * Mathf.Deg2Rad;


            float x = Mathf.Cos(radians);
            float y = Mathf.Sin(radians);

            Vector3 point = new Vector3(x, y, 0) * DetectionRadius + Enemy;

            Points.Add(point);

        }

        for (int p = 1; p < Points.Count; p++)
        {
            float Detectdistance = Vector3.Distance(Player.transform.position, Enemy);

            if (Detectdistance <= DetectionRadius)
            {
                col = Color.red;
                //Debug.Log("sus");
                transform.position = Vector3.MoveTowards(transform.position, Player.transform.position, movingSpeed * Time.deltaTime);
            }
            else
            {
                col = Color.green;
            }

            Debug.DrawLine(Points[p - 1], Points[p], col);

        }


    }

    public void DamageDetection()
    {
        Color colour = Color.green;

        for (int i = 0; i < AnglesInDegrees.Count; i++)
        {
            float degrees = AnglesInDegrees[i];
            float radians = degrees * Mathf.Deg2Rad;


            float x = Mathf.Cos(radians);
            float y = Mathf.Sin(radians);

            Vector3 point = new Vector3(x, y, 0) * DamageRadius + Enemy;

            Points.Add(point);
        }

        for (int p = 1; p < Points.Count; p++)
        {
            float distance = Vector3.Distance(Player.transform.position, Enemy);

            if (distance <= DamageRadius)
            {
                Destroy(gameObject);
                life -= 1;

                Debug.Log(life);
            }
            else
            {
                colour = Color.green;
            }

            Debug.DrawLine(Points[p - 1], Points[p], colour);
        }
    }
}
