using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; // Importa TMPro para usar TextMeshPro

public class BombManager : MonoBehaviour
{
    public TextMeshProUGUI levelCleared; // Cambia Text por TextMeshProUGUI

    private void Update()
    {
        AllBombCollected();  
    }

    public void AllBombCollected()
    {
        if (transform.childCount == 0)
        {
            Debug.Log("All bombs collected");
            levelCleared.gameObject.SetActive(true);
            Invoke("ChangeScene", 1);
        }
    }

    void ChangeScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
