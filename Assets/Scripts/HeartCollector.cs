using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartCollector : MonoBehaviour
{
    //pivoter
    private float turnSpeed = 90f;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Ninja")
        {

            Destroy(gameObject);
            Debug.Log("DestroYed! ");
        }

    }


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(turnSpeed * Time.deltaTime, 0, 0);
    }
}
