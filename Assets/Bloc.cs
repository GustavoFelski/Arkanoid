using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloc : MonoBehaviour
{
    public Rigidbody2D Rigidbody;
    public BoxCollider2D collider;



    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Rigidbody.constraints = new RigidbodyConstraints2D();
        collider.isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
