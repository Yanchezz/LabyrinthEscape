using UnityEngine;
public class WinZone : MonoBehaviour
{
    [SerializeField] private GameObject LvlCanvas;
    private LvlCanvasScript CanvasScript;
    private void Awake()
    {
        CanvasScript = LvlCanvas.GetComponent<LvlCanvasScript>();
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            CanvasScript.Win();
        }
    }
}