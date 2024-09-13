using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class strelbaaaaa : MonoBehaviour
{
    public GameObject pula;
    public Transform pulaPosition;
    private Quaternion pulaRotation;

    void Update()
    {
        pulaRotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y,272);
        if (Input.GetMouseButtonDown(0))
        {
        Instantiate(pula,pulaPosition.position,pulaRotation);

        }

    }
}
