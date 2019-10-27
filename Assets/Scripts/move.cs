using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    private Rigidbody rigidbody;

    public GameObject bullet;

    private bool judge = true;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        Debug.Log("Start!!");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        { 
            bullet.SetActive(true);
            Vector3 bulletposition = GameObject.Find("Gun").transform.position + new Vector3(0, 0, 0.9f);
            GameObject randomtarget = Instantiate(bullet, bulletposition, Quaternion.identity);
            bullet.SetActive(false);
        }
        
            if (Input.GetKey(KeyCode.UpArrow))
            {
                if (this.transform.position.z <= -5)
                {
                    this.gameObject.transform.position += new Vector3(0.0f, 0.0f, 0.1f);
                    Debug.Log("front");
                }
            }

            if (Input.GetKey(KeyCode.DownArrow))
            {
                if (this.transform.position.z >= -9)
                {
                    this.gameObject.transform.position += new Vector3(0.0f, 0.0f, -0.1f);
                    Debug.Log("back");
                }
            }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.transform.position.x >= -9.5)
            {
                this.gameObject.transform.position += new Vector3(-0.1f, 0.0f, 0.0f);
                Debug.Log("left");
            }
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (this.transform.position.x <= 9.5)
            {
                this.gameObject.transform.position += new Vector3(0.1f, 0.0f, 0.0f);
                Debug.Log("right");
            }
        }
        
        if (judge)
        {
            if (Input.GetKeyDown(KeyCode.Z))
            {
                rigidbody.AddForce(new Vector3 (0,350,0), ForceMode.Acceleration);
                judge = false;
                Debug.Log("jump");
                Invoke("Judge", 1.5f);
            }
        }
    }

    private void Judge()
    {
        judge = true;
    }
    
}
