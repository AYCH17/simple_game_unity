using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldCoin : MonoBehaviour
{

    //pivoter
    public float turnSpeed = 90f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Obstacle>() !=null)
        {
            Destroy(gameObject);
            return;
        }

            // Verifier la collision avec Ninja
            if (other.gameObject.name != "Ninja")
        {
            return;
        }
        //Ajouter du score

        GameManager.inst.IncrementScore();
        // Detruire les pieces
        Destroy(gameObject);
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
