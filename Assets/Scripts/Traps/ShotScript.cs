using UnityEngine;
public class ShotScript : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.down * speed, ForceMode.Impulse);
        Destroy(gameObject, 2);
    }
}