using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{

    //pivoter
    private readonly float turnSpeed = 90f;


    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Ninja")
        {

            Destroy(gameObject);
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
