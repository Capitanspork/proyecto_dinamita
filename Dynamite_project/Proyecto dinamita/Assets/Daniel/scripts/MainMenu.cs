using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene(1);
    }
    public void Opcions()
    {
        SceneManager.LoadScene(2);
    }
    public void Credits()
    {
        SceneManager.LoadScene(3);
    }
    public void Back()
    {
        SceneManager.LoadScene(0);
    }
    public void Exit()
    {
        Application.Quit();
    }
    public void nivel1()
    {
        SceneManager.LoadScene(4);
    }
    public void nivel2()
    {
        SceneManager.LoadScene(5);
    }


    public void selectGhost()
    {
        CharacterManager.Instance.personajeSeleccionado = 1;
    }
    public void selectKid()
    {
        CharacterManager.Instance.personajeSeleccionado = 2;
    }
}
