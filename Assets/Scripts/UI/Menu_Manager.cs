using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Manager : MonoBehaviour
{
    static Menu_Manager instance;

    [Header("Menu Inicio")]
    public string nameScene;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void Change_Scene()
    {
        if (!string.IsNullOrEmpty(nameScene))
        {
            SceneManager.LoadScene(nameScene);
            Debug.Log("There is scene");
        }
        else
        {
            Debug.LogError("These is not Scene");
        }
    }
    public void Quit_Aplication()
    {
        Application.Quit();
        Debug.Log("Quit Game");
    }

}
