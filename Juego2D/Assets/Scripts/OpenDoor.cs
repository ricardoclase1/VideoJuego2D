using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class OpenDoor : MonoBehaviour
{
    public TextMeshProUGUI text; // Cambia Text por TextMeshProUGUI
    public string levelName;
    private bool inDoor = false;

    private void OnTriggerEnter2D(Collider2D collision) // Corrige el nombre del método
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            text.gameObject.SetActive(true);
            inDoor = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        text.gameObject.SetActive(false); // Cambié a false para ocultar el texto al salir
        inDoor = false;
    }

    private void Update()
    {
        if (inDoor && Input.GetKey("x"))
        {
            SceneManager.LoadScene(levelName);
        }
    }
}
