using UnityEngine.SceneManagement;
using UnityEngine;

public class NinjaMoves : MonoBehaviour
{

    bool alive = true;
    public float speed = 5;
    public Rigidbody rb;

    float horizontalInput;
    public float horizontalNultiplier;

    private void FixedUpdate()
    {
        if (!alive) return;
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime * horizontalNultiplier;
        rb.MovePosition(rb.position + forwardMove);
    }

    // Update is called once per frame
    //private void Update()
    //{
    //    //horizontalInput = Input.GetAxis("Horizontal");
    //    if (transform.position.y < -5)
    //    {
    //        Die();
    //    }
    //}

    //public void Die()
    //{
    //    alive = false;
    //    //redemarrer le jeu
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    //}
}
