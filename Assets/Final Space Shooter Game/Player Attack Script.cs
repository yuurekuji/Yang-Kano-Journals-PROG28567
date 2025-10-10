using JetBrains.Annotations;
using System;
using UnityEngine;

public class PlayerAttackScript : MonoBehaviour
{

    public float stamina = 5f;
    float replenishRate = 1;

    public GameObject Bomb;

    public Transform enemy;


    public bool isRecharging = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        enemy = GameObject.FindGameObjectWithTag("Enemy").transform; // this will find the gameobject with the enemy tag and then get the transform.

    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpecialAttack(2, 2, enemy);
            stamina = 0;
            isRecharging = true;
        }

        if(isRecharging == true)
        {
            Invoke("replenishStamina", 2f);
        }

        if(stamina >= 5f)
        {
            isRecharging=false;
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

    public void SpecialAttack(float radius, float speed, Transform target)
    {
        if (stamina >= 5)
        {
            Vector2 BombSpawn = target.position * radius;
            Instantiate(Bomb, BombSpawn, Quaternion.identity);
        }
 

    }
}
