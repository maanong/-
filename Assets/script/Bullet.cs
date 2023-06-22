using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Moving moving;
    private Transform target;
    private int damage;
    
    public void Setup(Transform target, int damage)
    {
        moving = GetComponent<Moving>();
        this.target = target;
        this.damage = damage;
    }

    private void Update()
    {
        if ( target != null)
        {
            Vector3 direction = (target.position - transform.position).normalized;
            moving.MoveTo(direction);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Enemy")) return;
        if (collision.transform != target) return;

        collision.GetComponent<EnemyHP>().TakeDamage(damage);
        Destroy(gameObject);
    }
}