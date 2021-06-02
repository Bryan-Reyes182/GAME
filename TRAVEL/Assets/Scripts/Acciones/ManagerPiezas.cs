using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ManagerPiezas : MonoBehaviour
{
    public Text levelCleared;
    // Update is called once per frame
    private void Update()
    {
        Collected();
    }
    public void Collected()
    {
        if (transform.childCount == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }       
    }
}
