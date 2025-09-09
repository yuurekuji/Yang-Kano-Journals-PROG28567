using UnityEngine;
using static UnityEditor.PlayerSettings;

public class MathFunctions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector2 pos = transform.position;
        float magnitude = GetMagnitude(pos);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public float GetMagnitude(Vector2 position)
    {
        return Mathf.Sqrt(position.x * position.x + position.y * position.y);
    }
    
    public static void drawSquare()
    {

    }
}
