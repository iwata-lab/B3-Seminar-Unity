using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroytarget : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("destroy", 6);
    }

    void destroy()
    {
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
    }
}
