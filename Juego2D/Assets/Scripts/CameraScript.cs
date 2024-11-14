using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public GameObject Yong;

    void Update()
    {
        Vector3 position = transform.position;
        position.x = Yong.transform.position.x;
        transform.position = position;
    }
}
