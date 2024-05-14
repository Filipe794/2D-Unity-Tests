using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projetil : MonoBehaviour
{
    public float damage;

    void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Enemy")){
            if(collision.GetComponent<EnemyReceiveDamage>() != null){
                collision.GetComponent<EnemyReceiveDamage>().DealDamage(damage);
            }
            Destroy(gameObject);
        }

    }

}
