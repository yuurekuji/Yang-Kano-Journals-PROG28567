using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipeline1 : MonoBehaviour
{
    public List<Vector2> arrayMouse = new List<Vector2>();

    public float time;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        int index = arrayMouse.Count - 1;

        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            arrayMouse.Add(new Vector2(mousePos.x, mousePos.y));


        }

        if (Input.GetMouseButton(0))
        {
            time += Time.deltaTime;
            if(time >= 0.1f)
            {
                time = 0;
                arrayMouse.Add(new Vector2(mousePos.x, mousePos.y));
                Debug.DrawLine(mousePos, arrayMouse[index], Color.white, 20);
            }

        }

        if (Input.GetMouseButtonUp(0))
        {
            // calculate magnitude pog

        }
    }
}
