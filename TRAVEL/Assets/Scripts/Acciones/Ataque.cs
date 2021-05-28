using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataque : MonoBehaviour
{
    public Animator animator;
    public Transform AttackPoint;
    public Transform AttackPointB;
    public LayerMask enemyLayers;
    public float attackRange = 0.5f;
    public int attackDamage = 40;
    

    public float attackRotate = 2f;
    float nextAtackTime = 0f;

    // Update is called once per frame
      public void ATQ()
        {
            if (Time.time >= nextAtackTime)
            {
                
                    Attack();
                    nextAtackTime = Time.time + 1f / attackRotate;
                
            }
        }
    
    void Attack()
    {
        // Llama a la animacion de atacke
        animator.SetTrigger("Attak");

        // Detecta a los enemigos 
        Collider2D[] hitEnemies = Physics2D.OverlapCircleAll(AttackPoint.position, attackRange, enemyLayers);
        Collider2D[] hitEnemiesB = Physics2D.OverlapCircleAll(AttackPointB.position, attackRange, enemyLayers);
        // Daño a enemigo 
        foreach (Collider2D enemy in hitEnemies)
        {
            Debug.Log("Daño" + enemy.name);

            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }
        foreach (Collider2D enemy in hitEnemiesB)
        {
            Debug.Log("Daño" + enemy.name);

            enemy.GetComponent<Enemy>().TakeDamage(attackDamage);
        }
    }
    private void OnDrawGizmosSelected()
    {

        if (AttackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(AttackPoint.position, attackRange);

        if (AttackPoint == null)
        {
            return;
        }
        Gizmos.DrawWireSphere(AttackPointB.position, attackRange);
    }
    
}
