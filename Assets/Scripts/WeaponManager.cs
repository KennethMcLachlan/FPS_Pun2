using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{

    public GameObject playerCam;
    public float range = 100f;
    public float damage = 25f;
    public Animator playerAnimator;
    void Start()
    {
        
    }

    void Update()
    {
        if (playerAnimator.GetBool("isShooting"))
        {
            playerAnimator.SetBool("isShooting", false);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("Shot Fired");
            FireWeapon();

        }
    }

    private void FireWeapon()
    {
        playerAnimator.SetBool("isShooting", true);

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
