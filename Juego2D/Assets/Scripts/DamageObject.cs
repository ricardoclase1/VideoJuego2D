using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageObject : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            Debug.Log("Player Hit");

            PlayerRespawn playerRespawn = collision.transform.GetComponent<PlayerRespawn>();
            if (playerRespawn != null)
            {
                playerRespawn.PlayerDamaged();
            }
           
        }
    }
}
