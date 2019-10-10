using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    Rigidbody rigidbody;

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
        Invoke("bunish", 1);
    }

    void bunish()
    {
        //GameObject ball = Instantiate(this.gameObject, new Vector3(0, 0.20001f, -8.0f), Quaternion.identity);
        Destroy(this.gameObject);
    }
}
