using UnityEngine;

public class Ball : MonoBehaviour
{
    public ThrowBall tb;
    public float launchVelocity = 15f;
    public void Shoot()
    {
        Rigidbody rb = GetComponent<Rigidbody>();
        Vector3 launchDirection = transform.forward;
        launchDirection.y *= 1.5f;
        Vector3 initialVelocity = launchDirection * launchVelocity;
        rb.linearVelocity = initialVelocity;
        Invoke("reposition", 5);
    }
    public void reposition() 
    {
        tb.Reball();
        Destroy(gameObject);
    }
}