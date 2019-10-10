using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomTarget : MonoBehaviour
{
    float positionX;
    float positionY;
    float positionZ;
    float timeleft;

    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        timeleft = 2.0f;
    }

    // Update is called once per frame
    void Update()
    {

        timeleft -= Time.deltaTime;

        if (timeleft <= 0.0)
        {
            target.SetActive(true);
            timeleft = 6.0f;
            positionX = Random.Range(-8.0f, 8.0f);
            positionY = Random.Range(0.5f, 2.0f);
            positionZ = Random.Range(0.0f, 8.0f);
            Vector3 targetposition = new Vector3(positionX, positionY, positionZ);
            GameObject randomtarget = Instantiate(target, targetposition, Quaternion.identity);
            target.SetActive(false);
        }
    }
}
