using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAEnemy : MonoBehaviour
{
    public Animator animator;
    public SpriteRenderer spriteRenderer;
    public float speed = 0.5f;
    private float waitTime;
    public float startWiaitTime = 2;
    private int d = 0;
    private Vector2 actualPos;

    public Transform[] moveSpots;

    // Start is called before the first frame update
    void Start()
    {
        waitTime = startWiaitTime;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(CheckEnemyMovin());

        transform.position = Vector2.MoveTowards(transform.position, moveSpots[d].transform.position, speed * Time.deltaTime);
        if (Vector2.Distance(transform.position, moveSpots[d].transform.position) < 0.1f)
        {
            if (waitTime <= 0)
            {
                if (moveSpots[d] != moveSpots[moveSpots.Length - 1])
                {
                    d++;
                }
                else
                {
                    d = 0;
                }
                waitTime = startWiaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }

    }

    IEnumerator CheckEnemyMovin()
    {
        actualPos = transform.position;
        yield return new WaitForSeconds(0.5f);
        if (transform.position.x > actualPos.x)
        {
            spriteRenderer.flipX = true;
            animator.SetBool("Idle", false);
        }
        else if (transform.position.x < actualPos.x)
        {
            spriteRenderer.flipX = false;
            animator.SetBool("Idle", false);
        }
        else if (transform.position.x == actualPos.x)
        {
            animator.SetBool("Idle", true);
        }


    }
}
