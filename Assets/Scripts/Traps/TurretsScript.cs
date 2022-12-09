using UnityEngine;
public class TurretsScript : MonoBehaviour
{
    [SerializeField] private float startTimeDelay;
    [SerializeField] private GameObject bullet;
    [SerializeField] private GameObject shotPoint;
    private float timeDelay;
    private bool playerIsThere;
    private GameObject target;
    private void Awake()
    {
        timeDelay = startTimeDelay;
    }
    void Update()
    {
        if (target != null)
        {
            transform.LookAt(target.transform);
        }
    }
    private void FixedUpdate()
    {     if (playerIsThere)
        {
            if (timeDelay <= 0)
            {
                Shot();
                timeDelay = startTimeDelay;
            }
            else
            {
                timeDelay -= Time.deltaTime;
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            target = other.gameObject;
            playerIsThere = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            target = null;
            playerIsThere = false;
        }
    }
    private void Shot()
    {
        Instantiate(bullet, shotPoint.transform.position , Quaternion.LookRotation(-transform.up, -transform.forward));
        
    }
}
