using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooting : MonoBehaviour
{
    public GameObject projectile;
    public Transform player;
    public float minDamage;
    public float maxDamage;
    public float projectileForce;
    public float minCooldown;
    public float maxCooldown;

    void Start()
    {
        StartCoroutine(ShootPlayer());
    }

    IEnumerator ShootPlayer()
    {
        yield return new WaitForSeconds(Random.Range(minCooldown, maxCooldown));
        if (player != null)
        {
            GameObject spell = Instantiate(projectile, transform.position, Quaternion.identity);
            Vector2 myPos = transform.position;
            Vector2 targetPos = player.position;
            Vector2 direction = (targetPos - myPos).normalized;
            spell.GetComponent<Rigidbody2D>().velocity = direction * projectileForce;
            spell.GetComponent<EnemyProjectile>().damage = Random.Range(minDamage, maxDamage);
            StartCoroutine(ShootPlayer());
        }
    }
}
