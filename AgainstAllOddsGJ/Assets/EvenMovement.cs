using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EvenMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //originalCostraints = GetComponent<Rigidbody>().constraints;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player" && Input.GetKeyDown("k"))
        {
            collision.gameObject.transform.SetParent(transform);
            UnfreezeConstraints();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Player" && Input.GetKeyUp("k"))
        {
            collision.gameObject.transform.SetParent(null);
        }
    }

    private void UnfreezeConstraints()
    {
        rb.constraints = RigidbodyConstraints2D.None;
    }

    private void FreezeConstraints()
    {
        rb.constraints = RigidbodyConstraints2D.FreezeAll;
    }
}
