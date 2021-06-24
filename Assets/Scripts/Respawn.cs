using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    private bool grounded;
    [SerializeField]
    private Vector3 ogpos;
    
    // Start is called before the first frame update
    void Start()
    {
        ogpos = transform.position;  
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)

    {
        if (collision.gameObject.tag == "Wall")
        {
            grounded = true;
        }

       if (grounded == true)
        {
            transform.position = ogpos;
       }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        grounded = false;
    }

}
