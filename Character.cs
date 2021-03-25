using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    
    public Rigidbody2D rb;
    public float move = 0f;
    public float speed = 10f;
    public float health = 1;
    private bool Damage;
    [SerializeField]
    private GameObject Player;
    private Vector3 Spawn;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Spawn = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Vertical");
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(rb.velocity.y, move * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Hit")
        {
            Damage = true;
        }

        if(Damage == true)
        {
            health = health - 1;
            transform.position = Spawn;
            Player.SetActive(false);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Damage = false;
    }
}

