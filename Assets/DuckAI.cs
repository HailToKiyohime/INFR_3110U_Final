using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckAI : MonoBehaviour
{
    public float flyspeed;
    public Rigidbody2D rb;
    [HideInInspector]
    public bool flying;

    private void Start()
    {
        flying = true;
    }
    // Update is called once per frame
    void Update()
    {
        if (flying)
        {
            fly();
            Flip();
        }
    }
    void fly()
    {
        rb.velocity=  new Vector2(flyspeed * Time.fixedDeltaTime, rb.velocity.y);
    }
    void Flip()
    {
        if (flyspeed > 0 && transform.localPosition.x > 10.6)
        {
            transform.localScale = new Vector2(transform.localScale.x * -1, -transform.localScale.y);
            flyspeed *= -1;
        }
        if (flyspeed < 0 && transform.localPosition.x < -10.6)
        {
            transform.localScale = new Vector2(transform.localScale.x * -1, -transform.localScale.y);
            flyspeed *= -1;
        }
    }
}
