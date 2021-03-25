using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggMovement : MonoBehaviour
{
    [SerializeField]
    private float MOVE = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.right * MOVE * Time.deltaTime;
    }
}
