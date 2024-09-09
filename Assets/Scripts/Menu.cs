using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{

    public void comenzarnivel(string nivel)
    {
        SceneManager.LoadScene(nivel);
    }


    public void salir()
    {
        Application.Quit();
        Debug.Log("Salio del juego");
    }
}
