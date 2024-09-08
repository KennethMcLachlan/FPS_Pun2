using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{

    public GameObject playerCam;
    public float range = 100f;
    public float damage = 25f;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Shot Fired");
            FireWeapon();
        }
    }

    private void FireWeapon()
    {
        RaycastHit hit;

        if (Physics.Raycast(playerCam.transform.position, transform.forward, out hit, range))
        {
            //Debug.Log("Hit a collider");

            EnemyManager enemyManager = hit.transform.GetComponent<EnemyManager>();
            if (enemyManager != null)
            {
                enemyManager.TakeHit(damage);
                Debug.Log("Hit the enemy");
            }
        }
    }
}
