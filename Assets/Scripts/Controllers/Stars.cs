using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Stars : MonoBehaviour
{
    public List<Transform> starTransforms;
    public float drawingTime;
    public float progress;

    // Update is called once per frame
    private void Start()
    {

    }
    void Update()
    {

            drawConstellation();
        


    }

    public IEnumerator IterateStarsLoop()
    {
        for (int i = 1; i < starTransforms.Count; i++)
        {


            Vector3 StartPos = starTransforms[i - 1].transform.position;
            Vector2 EndPos = starTransforms[i].transform.position;

            Vector3 CurrentEndPos = Vector3.Lerp(StartPos, EndPos, progress);

            Debug.DrawLine(StartPos, CurrentEndPos, Color.white);

            yield return new WaitForSeconds(drawingTime);

        }
    }
    public void drawConstellation()
    {
        
        progress += Time.deltaTime * drawingTime;
        progress = Mathf.Clamp01(progress);
        StartCoroutine(IterateStarsLoop());

    }
}
