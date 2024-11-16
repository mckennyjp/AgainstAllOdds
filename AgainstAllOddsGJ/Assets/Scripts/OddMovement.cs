using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OddMovement : MonoBehaviour
{

    [SerializeField] Animator anim;

    public Rigidbody2D rb;
    public GameObject even;
    public string newTag;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        if (collision2D.collider.CompareTag("Odd"))
        {
            //rb.constraints = RigidbodyConstraints2D.FreezeAll;
            //anim.SetTrigger("OddtoEven");
            //Destroy(collision2D.rigidbody);
            //gameObject.tag = newTag;

            ThreeManager.instance.OnOddDestroyed(transform.position);
            Destroy(gameObject);
            
        }
    }
}
