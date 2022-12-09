using UnityEngine;
public class DeathZone : MonoBehaviour
{
    [SerializeField] private GameObject LvlCanvas;
    private LvlCanvasScript CanvasScript;
    private void Awake()
    {
        CanvasScript = LvlCanvas.GetComponent<LvlCanvasScript>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CanvasScript.Fall();
        }
    }
}