using TMPro;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEditor.PlayerSettings;

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
        unit += Input.mouseScrollDelta.y * 0.1f;

        bool buttonDown = Input.GetMouseButtonDown(0);

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

        if (buttonDown == true)
        {
            Debug.DrawLine(topleftcorner, toprightcorner, Color.white, Mathf.Infinity);
            Debug.DrawLine(topleftcorner, bottomleftcorner, Color.white, Mathf.Infinity);
            Debug.DrawLine(toprightcorner, bottomrightcorner, Color.white, Mathf.Infinity);
            Debug.DrawLine(bottomrightcorner, bottomleftcorner, Color.white, Mathf.Infinity);
        }




    }


}
