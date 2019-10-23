using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class projectile : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rgb;
    private int p1Score;
    private int p2Score;
    // Start is called before the first frame update
    void Start()
    {
        rgb = GetComponent<Rigidbody2D>();
        //rgb.velocity = new Vector2(speed * Time.deltaTime, 0);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Translate(0, speed * Time.deltaTime, 0);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "P1")
        {
            p1Score++;
        }
        else if(collision.gameObject.tag == "P2")
        {

        }
    }
}
