using UnityEngine;

public class PauseMan : MonoBehaviour
{
    public GameObject MenuPaus;
    private bool isPaused = false;

    void Start()
    {
        MenuPaus.SetActive(false);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    
    //Codi Pausa general
    void Pause()
    {
        MenuPaus.SetActive(true);
        Time.timeScale = 0f; // THE WORLD HAS NO WEAKNESSES !!!
        isPaused = true;
    }

    //Codi per des-pausar
    public void Resume()
    {
        MenuPaus.SetActive(false);
        Time.timeScale = 1f; // The weakness:
        isPaused = false;
    }

}