using UnityEngine;
public class BarrelTrapSript : MonoBehaviour
{
    [SerializeField] private bool Reverse;
    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>(); 
    }
    private void FixedUpdate()
    {
        if (!Reverse)
        {
            rb.velocity = Vector3.back;
        }
        else
        {
            rb.velocity = Vector3.forward;
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("TrapReverse"))
        {
            if (!Reverse)
            {
                Reverse = true;
            }
            else
            {
                Reverse = false;
            }
        }
    }
}