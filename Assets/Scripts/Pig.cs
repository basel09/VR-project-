using UnityEngine;

public class Pig : MonoBehaviour
{
    public GameObject Smoke;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.relativeVelocity.magnitude > 5f)
        {
            Destroy();
        }
    }

    private void Destroy()
    {
        
        Destroy(gameObject);
    }
}