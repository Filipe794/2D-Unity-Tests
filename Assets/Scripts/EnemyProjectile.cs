using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public float damage;

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Player")){
            // if(collision.GetComponent<EnemyReceiveDamage>() != null){
            //     collision.GetComponent<EnemyReceiveDamage>().DealDamage(damage);
            // }
            Destroy(gameObject);
        }
    }
}
