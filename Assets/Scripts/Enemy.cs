using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    // Start is called before the first frame update
    public float enemySpeed;
    void Start()
    {
        Destroy(gameObject,7);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * enemySpeed * Time.deltaTime;
    }
}
