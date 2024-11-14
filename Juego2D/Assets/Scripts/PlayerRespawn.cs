using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerRespawn : MonoBehaviour
{
public Animator animator;

   public void PlayerDamaged()
   {
      animator.Play("Hit");
      SceneManager.LoadScene(SceneManager.GetActiveScene().name);
   }

}
