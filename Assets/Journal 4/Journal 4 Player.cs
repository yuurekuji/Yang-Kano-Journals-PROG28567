using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Journal4Player : MonoBehaviour
{
    public List<float> AnglesInDegrees = new List<float>();
    public List<Vector3> Points = new List<Vector3>();

    public int CurrentIndex = 0;
    public float radius;

    public Vector3 Player;

    public Transform Enemy;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Player = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        EnemyDetection();
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

            Vector3 point = new Vector3(x, y, 0) * radius + Player;

            Points.Add(point);
        }

        for (int p = 1; p < Points.Count; p++)
        {
            float distance = Vector3.Distance(Enemy.transform.position, Player);

            if (distance <= radius)
            {
                col = Color.red;
            }
            else
            {
                col = Color.green;
            }

            Debug.DrawLine(Points[p-1], Points[p], col);
        }


    }
}
