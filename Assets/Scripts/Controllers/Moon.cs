using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Moon : MonoBehaviour
{
    public Transform planetTransform;

    public float rad;
    public float moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OrbitalMotion(rad, moveSpeed, planetTransform);
    }

    public void OrbitalMotion(float radius, float speed, Transform target)
    {
        Vector3 orbit = target.position;

        Vector2 direction = transform.position - orbit;

        float AngleInRad = Mathf.Atan2 (direction.y, direction.x); // https://docs.unity3d.com/6000.2/Documentation/ScriptReference/Mathf.Atan2.html This helped alot lmfao

        AngleInRad += speed * Time.deltaTime;

        float x = orbit.x + radius * Mathf.Cos(AngleInRad);
        float y = orbit.y + radius * Mathf.Sin(AngleInRad);

        transform.position = new Vector3(x, y, transform.position.z);
    }
}
