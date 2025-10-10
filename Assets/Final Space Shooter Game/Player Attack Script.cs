using JetBrains.Annotations;
using System;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class PlayerAttackScript : MonoBehaviour
{

    public float stamina = 5f;
    float replenishRate = 1;

    public GameObject Bomb;

    public Transform enemy;

    public float angles;

    public bool isRecharging = false;
    public bool attackIsLive = false;
    public bool lockedON = false;



    public float distanceBetween;
    GameObject bombattack;
    GameObject EnemyObject;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy").transform; // this will find the gameobject with the enemy tag and then get the transform.
        EnemyObject = GameObject.FindGameObjectWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {

        distanceBetween = Vector2.Distance(transform.position, enemy.transform.position); // currently this gives an error after you destroy the enemy as there is no enemies that exist anymore.

        if (distanceBetween < 4)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (stamina >= 5)
                {
                    Vector2 BombSpawn = enemy.position * 2;

                    bombattack = Instantiate(Bomb, BombSpawn, Quaternion.identity);

                }

                stamina = 0;
                isRecharging = true;

                attackIsLive = true;
            }

            if (attackIsLive == true)
            {
                MoveAttack(2, 2, enemy, bombattack.transform);
            }

            if (lockedON == true)
            {
                chargeToEnemy(bombattack.transform, enemy, 2);
            }
            if (isRecharging == true)
            {
                Invoke("replenishStamina", 2f);
            }

            if (stamina >= 5f)
            {
                isRecharging = false;
            }
        }


    }
    
    // code to replenish stamina
    public void replenishStamina()
    {
        if(stamina<= 5f) // checks if stamina is under 5 and then consitently replenishes stamina by a replenish rate amount.
        {
            stamina += replenishRate * Time.deltaTime;
            
        }
        
    }

    public void MoveAttack(float radius, float speed, Transform target, Transform attack)
    {
        // moving the bomb
        Vector3 orbit = target.position;

        Vector2 direction = attack.transform.position - orbit;

        float angleInRad = Mathf.Atan2(direction.y, direction.x);


        angleInRad += speed * Time.deltaTime;

        float x = orbit.x + radius * Mathf.Cos(angleInRad);
        float y = orbit.y + radius * Mathf.Sin(angleInRad);

        angles = angleInRad * Mathf.Rad2Deg;

        attack.transform.position = new Vector3(x, y, attack.transform.position.z);

        if (angles >= -13 && angles <= -10)
        {
            Debug.Log("locked on");
            attackIsLive = false;
            lockedON = true;
        }
    }

    public void chargeToEnemy(Transform attack, Transform enemy, float speed)
    {
        attack.position = Vector3.MoveTowards(attack.position, enemy.position, speed * Time.deltaTime);
        
        float distance = Vector2.Distance(attack.position, enemy.position);

        if(distance <= 0.5)
        {
            Destroy(bombattack);
            lockedON = false;
            Destroy(EnemyObject);
        }
    }
}
