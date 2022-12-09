using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private LvlCanvasScript lvlCanvas;
    private Rigidbody rb;
    private PlayerInput input;
    private Vector3 vec;
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        input = GetComponent<PlayerInput>();
    }
    private void FixedUpdate()
    {
        vec = input.InputVector();
        rb.velocity = new Vector3(-vec.y, 0, vec.x) * speed;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 8)
        {
            lvlCanvas.Fall();
        }
    }
}