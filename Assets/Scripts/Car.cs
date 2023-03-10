using UnityEngine;
using UnityEngine.UI;

public class Car : MonoBehaviour
{
    public Rigidbody2D rb;

    public float minSpeed = 5f;
    public float maxSpeed = 20f;

    float speed = 1f;

    float newspeed = CarSpeed.Speed;

    void Start ()
    {
        //speed = Random.Range(minSpeed, maxSpeed);
    }

    void FixedUpdate()
    {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * newspeed * Time.fixedDeltaTime * speed);
    }

    void DestroyObjectDelayed()
    {
        // Kills the game object in 5 seconds after loading the object
        Destroy(gameObject, 2);
    }
}
