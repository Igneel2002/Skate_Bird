using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Game2 : MonoBehaviour
{
    [SerializeField]
    private float move;
    public float Points = 0f;
    [SerializeField]
    private float Speed1 = 5;

    // the max difference in points when calculating if we can speed up or not
    private float pointThreshold = 1;

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.right * Speed1 * Time.deltaTime;

        if (Points < 4000)
        {
            Points += 200 * Time.deltaTime;
        }
        else if (Points < 8000)
        {
            Points += 400 * Time.deltaTime;
        }
        else if (Points < 12000)
        {
            Points += 600 * Time.deltaTime;
        }
        else if (Points < 16000)
        {
            Points += 800 * Time.deltaTime;
        }
        else if (Points < 20000)
        {
            Points += 1200 * Time.deltaTime;
        }
        else if (Points < 24000)
        {
            Points += 1400 * Time.deltaTime;
        }
        if (Mathf.Abs(Points - 4000f) < pointThreshold)
        {
            Speed1 = Speed1 + 2;
        }
        if (Mathf.Abs(Points - 8000f) < pointThreshold)
        {
            Speed1 = Speed1 + 2;
        }
        if (Mathf.Abs(Points - 12000f) < pointThreshold)
        {
            Speed1 = Speed1 + 2;
        }
        if (Mathf.Abs(Points - 16000f) < pointThreshold)
        {
            Speed1 = Speed1 + 2;
        }
        if (Mathf.Abs(Points - 20000f) < pointThreshold)
        {
            Speed1 = Speed1 + 2;
        }
        if (Mathf.Abs(Points - 24000f) < pointThreshold)
        {
            Speed1 = Speed1 + 2;
        }

    }
}
 