using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movPula : MonoBehaviour
{
    private int speed = 20;

    void Update()
    {
        transform.Translate(Vector3.up * speed * Time.deltaTime);
    }

}
