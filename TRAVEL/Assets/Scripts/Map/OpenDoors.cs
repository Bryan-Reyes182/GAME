using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenDoors : MonoBehaviour
{

    public Button boton;
    public string LevelName;
    private bool inDoor = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            boton.gameObject.SetActive(true);
            inDoor = true;
            Debug.Log("Entro");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        boton.gameObject.SetActive(false);    
        inDoor =false;   
    }


    public void Interactuar()
    {
        if (inDoor)
        {
            SceneManager.LoadScene(LevelName);
        }
    }
}
