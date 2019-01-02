using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatController : MonoBehaviour
{
    bool started;
    public float upForce;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        started = false;
        rb = GetComponent<Rigidbody2D>();
        rb.isKinematic = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!started)
        {
            if (Input.GetMouseButtonDown(0))
            {
                started = true;
                // rb.bodyType = RigidbodyType2D.Dynamic;
                rb.isKinematic = false;
            }
        }
        else
        {
                if (Input.GetMouseButtonDown(0))
                {
                    rb.velocity = new Vector2(0, 0);
                    rb.AddForce(new Vector2(0, upForce));
                }
        }
        
        
    }
}
