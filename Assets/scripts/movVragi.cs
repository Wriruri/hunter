using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movVragi : MonoBehaviour
{
    private int speed = 10;
        
    

    void Update()
    {
        transform.Translate (Vector3.forward * speed * Time.deltaTime);
    }
}
