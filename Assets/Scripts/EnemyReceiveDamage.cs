using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyReceiveDamage : MonoBehaviour
{
    
    public float health;
    public float maxHealth;

    void Start()
    {
        health = maxHealth;
    }

    public void DealDamage(float damage){
        health -= damage;
        CheckDeath();
    }
    
    private void CheckDeath(){
        if(health <= 0){
            Destroy(gameObject);
        }
    }
}