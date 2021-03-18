using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Game : MonoBehaviour
{
    [SerializeField]
    private float move;
    [SerializeField]
    private float Points = 0f;
    [SerializeField]
    private float Speed = 5;

    // the max difference in points when calculating if we can speed up or not
    private float pointThreshold = 1;

    // Update is called once per frame
    void Update()
    {
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
        transform.position -= transform.right * Speed * Time.deltaTime;
        
        if (Mathf.Abs(Points - 4000f) < pointThreshold)
        {
            Speed = Speed + 2;
        }
        if (Mathf.Abs(Points - 8000f) < pointThreshold)
        {
            Speed = Speed + 2;
        }
        if (Mathf.Abs(Points - 12000f) < pointThreshold)
        {
            Speed = Speed + 2;
        }
        if (Mathf.Abs(Points - 16000f) < pointThreshold)
        {
            Speed = Speed + 2;
        }
        if (Mathf.Abs(Points - 20000f) < pointThreshold)
        {
            Speed = Speed + 2;
        }
        if (Mathf.Abs(Points - 24000f) < pointThreshold)
        {
            Speed = Speed + 2;
        }

    }
}
 