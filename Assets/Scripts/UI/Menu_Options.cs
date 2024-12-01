using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Options : MonoBehaviour
{
    [Header("Menus")]
    public GameObject menuPausa;
    public GameObject menuOptions;
    public GameObject menuPrincipal;
    public string nameScene;

    public bool isPause = false;
    private void Start()
    {
        isPause = false;
        menuPausa.SetActive(false);
        Time.timeScale = 1.0f;
        Cursor.visible = false;
    }
    private void Update()
    {
        AbrirMenuPausa();
    }
    //Sirve cuando le das al Escape se abra el menu de pausa principal, lo que ocurre es que puedas cerrar con el mismo boton usando bool(isPause)
    public void AbrirMenuPausa()
    {
        if (isPause == false)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Time.timeScale = 0;
                menuPausa.SetActive(true);
                isPause = true;
                Debug.Log("Open menu Pause");
                Cursor.visible = true;
            }
        }
        else if (isPause == true)
        {
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                menuPrincipal.SetActive(true);
                menuOptions.SetActive(false);
                menuPausa.SetActive(false);
                Time.timeScale = 1;
                isPause = false;
                Debug.Log("Closed menu pause");
                Cursor.visible = false;
            }
        }
    }
    public void Cerrar_Menu_Pausa()
    {
        Time.timeScale = 1;
        menuPausa.SetActive(false);
        menuOptions.SetActive(false);
        isPause = false;
        Debug.Log("Close menu pause");
        Cursor.visible = false;
    }
    //Este void sirve para salir del videojuego
    public void Quit()
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
        Debug.Log("Back Menu Inicio");
    }
    //Este void sirve para abrir el menu de Options mediante botones
    public void Menu_Options_UI()
    {
        menuOptions.SetActive(true);
        menuPrincipal.SetActive(false);
        Debug.Log("Open Options");
    }
    public void BackMenu()
    {
        menuOptions.SetActive(false);
        menuPrincipal.SetActive(true);
        Debug.Log("Back Menu Pause");
    }
}
