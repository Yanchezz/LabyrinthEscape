using UnityEngine;
public class CollectBonusScript : MonoBehaviour
{
    [SerializeField] private LvlCanvasScript LvlCanvasScript;
    [SerializeField] private AudioSource collectSound;
    [SerializeField] private float bonusTime;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            collectSound.Play();
            LvlCanvasScript.currentTime += bonusTime;
            LvlCanvasScript.startTime += bonusTime;
            Destroy(gameObject);
        }
    }
}