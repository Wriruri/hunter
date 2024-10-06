using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonestersD: MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("monester"))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }



}
