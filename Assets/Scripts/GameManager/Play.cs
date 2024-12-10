using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void LoadScene(int Number)
    {
        SceneManager.LoadScene(Number);
    }

    public void Close()
    {
        Application.Quit();
    }
}
