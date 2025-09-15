using TMPro;
using UnityEngine;
using static UnityEditor.PlayerSettings;

public class Task3Player : MonoBehaviour
{
    public Transform enemyTransform;
    //public TMP_InputField input;

    public float ratio;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 startPos = transform.position;
        Vector2 enemyPos = enemyTransform.position;

        if (Input.GetKeyDown(KeyCode.W))
        {
            if(ratio > 1)
            {
                ratio = 1;
                WarpPlayer(enemyTransform, ratio);
            }
            
        }
    }

    public void WarpPlayer(Transform target, float ratio)
    {

        Vector2 pos = transform.position;
        Vector2 direction = target.transform.position;

        
        pos -= ((Vector2)transform.position - direction) * ratio;

        transform.position = pos;


        
    }
}
