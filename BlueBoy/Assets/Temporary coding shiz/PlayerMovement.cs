using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb.addforce(0, 100000);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
