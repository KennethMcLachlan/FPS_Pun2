using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyManager : MonoBehaviour
{
    public GameObject player;
    [SerializeField] private Animator _enemyAnimator;
    public float damage = 20f;
    public float health = 100f;
    public GameManager gameManager;

    public void TakeHit(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            gameManager.enemiesAlive--;
            //Destroy the enemy (Zombie)
            Destroy(gameObject);
        }
    }

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        GetComponent<NavMeshAgent>().destination = player.transform.position;
        if (GetComponent<NavMeshAgent>().velocity.magnitude > 1)
        {
            _enemyAnimator.SetBool("isRunning", true);
        }
        else
        {
            _enemyAnimator.SetBool("isRunning", false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == player)
        {
            player.GetComponent<PlayerManager>().TakeDamage(damage);
        }
    }
}
