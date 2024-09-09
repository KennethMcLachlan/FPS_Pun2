using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public float health = 100f;
    public TMP_Text healthText;

    public GameManager gameManager;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        
    }

    public void TakeDamage(float damage)
    {
        Debug.Log("Player has been hit");
        health -= damage;
        healthText.text = "Health: " + health.ToString();

        if (health <= 0f)
        {
            gameManager.EndGame();
        }
    }

}
