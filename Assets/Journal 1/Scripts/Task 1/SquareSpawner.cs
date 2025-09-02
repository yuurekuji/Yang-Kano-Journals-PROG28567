using TMPro;
using UnityEngine;

public class SquareSpawner : MonoBehaviour
{


    float unit = 0.1f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        Vector2 mousePos = Input.mousePosition;

        Vector2 origin = new Vector2(0f, 0f);

        Vector2 worldMousePos = Camera.main.ScreenToWorldPoint(mousePos);

        Vector2 topleftcorner = new Vector2(worldMousePos.x - unit, worldMousePos.y + unit);
        Vector2 toprightcorner = new Vector2(worldMousePos.x + unit, worldMousePos.y + unit);
        Vector2 bottomleftcorner = new Vector2(worldMousePos.x - unit, worldMousePos.y - unit);
        Vector2 bottomrightcorner = new Vector2(worldMousePos.x + unit, worldMousePos.y - unit);

        float x = mousePos.x;
        float y = mousePos.y;

        Debug.DrawLine(topleftcorner, toprightcorner, Color.grey);
        Debug.DrawLine(topleftcorner, bottomleftcorner, Color.grey);
        Debug.DrawLine(toprightcorner, bottomrightcorner, Color.grey);
        Debug.DrawLine(bottomrightcorner, bottomleftcorner, Color.grey);

        if (Input.GetMouseButton(0))
        {
            Debug.DrawLine(topleftcorner, toprightcorner, Color.red);
            Debug.DrawLine(topleftcorner, bottomleftcorner, Color.red);
            Debug.DrawLine(toprightcorner, bottomrightcorner, Color.red);
            Debug.DrawLine(bottomrightcorner, bottomleftcorner, Color.red);
        }




    }
}
