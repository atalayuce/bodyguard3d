using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadSpawner : MonoBehaviour
{
    public GameObject road;
    public float sure;
    void Start()
    {
        StartCoroutine(RSpawner());
    }

    // Update is called once per frame
    public IEnumerator RSpawner()
    {
        while (true)
        {
            Instantiate(road, new Vector3(-50,0,-0.73f), Quaternion.identity);
            yield return new WaitForSeconds(sure);
        }
        
    }
}
