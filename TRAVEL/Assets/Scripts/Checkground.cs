using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkground : MonoBehaviour
{
    public static bool isGrounded;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
        Debug.Log("Esta en el suelo");
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        isGrounded = false;
    }
}
