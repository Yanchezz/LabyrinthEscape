using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
    [SerializeField] private GameObject menuWindow;
    [SerializeField] private AudioSource clickSound;
    private GameObject currentWindow;
    private void Awake()
    {
        currentWindow = menuWindow;
        currentWindow.SetActive(true);
    }
    public void ChangeWindow(GameObject nextWindow)
    {
        if (currentWindow != null)
        {
            currentWindow.SetActive(false);
            nextWindow.SetActive(true);
            currentWindow = nextWindow;
        }
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void ChooseLvl(int bildIndex)
    {
        SceneManager.LoadScene(bildIndex);
    }
    public void Click()
    {
        clickSound.Play();
    }
}