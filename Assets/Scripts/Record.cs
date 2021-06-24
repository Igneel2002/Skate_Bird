using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Record : MonoBehaviour
{
    public TextMeshProUGUI PointsText;
    public float Points = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PointsText.text = Points.ToString("F");

        if (Points < 4000)
        {
            Points += 200 * Time.deltaTime;
        }
        else if(Points < 8000)
        {
            Points += 400 * Time.deltaTime;
        }
        else if(Points < 12000)
        {
            Points += 600 * Time.deltaTime;
        }
        else if(Points < 16000)
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

    }
}
