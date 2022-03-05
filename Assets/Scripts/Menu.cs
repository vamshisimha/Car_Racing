using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
   
    public void start()
    {
        SceneManager.LoadScene(1);
    }
    public void playagain()
    {
        SceneManager.LoadScene(1);

    }
    public void restart()
    {
        SceneManager.LoadScene(1);

    }

    public void Quit()
    {
        Application.Quit();
    }
}
