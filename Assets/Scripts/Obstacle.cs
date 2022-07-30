using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour

{
    [SerializeField] private float speed;
    private float previous_x;

    private Animator anim;
    // Start is called before the first frame update
    private  void Start()
    {
        anim = FindObjectOfType<PlayerController>().gameObject.GetComponentInChildren<Animator>();


        previous_x = transform.localPosition.x;

        if (Random.Range(0, 2) == 1)
        {
            transform.localPosition -= new Vector3(speed * Time.deltaTime, 0f, 0f);

        }
        else 
        {
            transform.localPosition += new Vector3(speed * Time.deltaTime, 0f, 0f);
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger Enter");

        if (other.gameObject.name == "Ninja")
        {
            anim.SetTrigger("Collision");
            // show continue panel?
            // exit to the menu 
        }
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.collider.gameObject.name == "Ninja")
        {
            Debug.Log("Collision Enter");
            anim.SetTrigger("Collision");
        }

    } 
    void Update()
    {
        float current_x = transform.position.x;

     if( current_x <= previous_x)
        {
            if(current_x <= -transform.parent.localScale.x / 2f - 20f)
            {
                transform.localPosition += new Vector3(speed * Time.deltaTime, 0f, 0f);
            }
            else
            {
                transform.localPosition -= new Vector3(speed * Time.deltaTime, 0f, 0f);
            }
                
        }
     else 
        {
            
            if (current_x >= transform.parent.localScale.x / 2f + 20f)
            {
                transform.localPosition -= new Vector3(speed * Time.deltaTime, 0f, 0f);
            }

            else
            {
                transform.localPosition += new Vector3(speed * Time.deltaTime, 0f, 0f);

            }

        }

        previous_x = current_x;


    }
}
