using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    private Rigidbody rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = new Vector3(0, 0, 25);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Target")
        {
            Counter.HitCount++;
            Debug.Log(Counter.HitCount+" Hit");
        }
        Invoke("vanish", 1);
    }

    private void vanish()
    {
        Destroy(this.gameObject);
    }
}
