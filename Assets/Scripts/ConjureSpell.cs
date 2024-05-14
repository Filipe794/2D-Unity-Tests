using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConjureSpell : MonoBehaviour
{
   public GameObject projectile;
   public float minDamage;
   public float maxDamage;
   public float projectileForce;
   public float lifetime = 3.0f;

   void Update(){
    if(Input.GetMouseButtonDown(0)){
        GameObject spell = Instantiate(projectile, transform.position, Quaternion.identity);
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition); // o projetil vai atirar para onde o mouse está
        Vector2 myPos = transform.position;
        Vector2 direction = (mousePos - myPos).normalized; // normalized pra n afetar a força
        spell.GetComponent<Rigidbody2D>().velocity = direction * projectileForce;
        spell.GetComponent<Projetil>().damage = Random.Range(minDamage,maxDamage);
        Destroy(spell,lifetime);
    }
   }
}
