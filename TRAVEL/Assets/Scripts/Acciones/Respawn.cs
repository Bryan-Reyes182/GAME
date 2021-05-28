using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{

    public Animator animator;
    public GameObject[] hearts;
    int life;
    // Start is called before the first frame update
    void Start()
    {
        life = hearts.Length;
    }

    // Update is called once per frame
    void CheckLife()
    {
     if(life < 1)
        {
            Destroy(hearts[0].gameObject);
            animator.Play("Hit");
            StartCoroutine("Esperar");
        }
        else if (life < 2)
        {
            Destroy(hearts[1].gameObject);
            animator.Play("Daño");
        }
    
     else if(life < 3)
        {
            Destroy(hearts[2].gameObject);
            animator.Play("Daño");
        }
    }

    public void PlayerDamage()
    {
        life--;
        CheckLife();
    }
    IEnumerator Esperar()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
