using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public float health = 100f;


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

        if (health <= 0f)
        {
            SceneManager.LoadScene(0);
        }
    }

}
