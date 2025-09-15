using TMPro;
using UnityEngine;

public class Task3Player : MonoBehaviour
{
    public Transform enemyTransform;
    public GameObject bombPrefab;
    public Transform bombsTransform;
    public TMP_InputField input;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 startPos = transform.position;
        Vector2 enemyPos = enemyTransform.position;

        if (Input.GetKeyDown(KeyCode.N))
        {
            WarpPlayer(enemyTransform, 20);
        }
    }

    public void WarpPlayer(Transform target, float ratio)
    {

    }
}
