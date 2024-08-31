using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movPiman : MonoBehaviour
{
    private int speed = 10;

    void Update()
    {
        transform.Translate(Vector3.down * speed * Time.deltaTime);
    }
}
