using UnityEngine;

public class PlayerAttackScript : MonoBehaviour
{

    public float stamina = 5f;
    float replenishRate = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        stamina = 0;
    }

    // Update is called once per frame
    void Update()
    {
        replenishStamina(); 

        if (Input.GetKeyDown(KeyCode.Space))
        {
            stamina = 0;
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
}
