using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnMonsteres : MonoBehaviour
{
    public GameObject[] monesters;
    private int index;
    private Vector3 position;
    private void Start()
    {
        InvokeRepeating("AAaaaaaaopatmonstre", 2, 1);   
    }
void AAaaaaaaopatmonstre()
    {
        position = new Vector3(Random.Range(-100 ,0.7f),10,Random.Range(112, 212));
        index = Random.Range(0, monesters.Length);

        Instantiate(monesters[index], position, monesters[index].transform.rotation);

    }




}
