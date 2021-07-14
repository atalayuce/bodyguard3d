using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public float enemyfr;
    public GameObject enemy;
    int laneno;
    float L1 = -3.85f, L2 = -1.4f, L3 = 1.2f, L4 = 3.7f;
    void Start()
    {
        StartCoroutine(ESpawner());
    }

    // Update is called once per frame
    public IEnumerator ESpawner()
    {
        while (true)
        {
            laneno = Random.Range(1, 11);
            if (laneno==1)
            {
                Instantiate(enemy, new Vector3(-40, -0.45f, L1), Quaternion.Euler(0,90,0));
                yield return new WaitForSeconds(enemyfr);
            }
            else if (laneno == 2)
            {
                Instantiate(enemy, new Vector3(-40, -0.45f, L2), Quaternion.Euler(0, 90, 0));
                yield return new WaitForSeconds(enemyfr);
            }
            else if (laneno == 3)
            {
                Instantiate(enemy, new Vector3(-40, -0.45f, L3), Quaternion.Euler(0, 90, 0));
                yield return new WaitForSeconds(enemyfr);
            }
            else if (laneno == 4)
            {
                Instantiate(enemy, new Vector3(-40, -0.45f, L4), Quaternion.Euler(0, 90, 0));
                yield return new WaitForSeconds(enemyfr);
            }
            else if (laneno == 5)
            {
                Instantiate(enemy, new Vector3(-40, -0.45f, L1), Quaternion.Euler(0, 90, 0));
                Instantiate(enemy, new Vector3(-40, -0.45f, L3), Quaternion.Euler(0, 90, 0));
                yield return new WaitForSeconds(enemyfr);
            }
            else if (laneno == 6)
            {
                Instantiate(enemy, new Vector3(-40, -0.45f, L2), Quaternion.Euler(0, 90, 0));
                Instantiate(enemy, new Vector3(-40, -0.45f, L4), Quaternion.Euler(0, 90, 0));
                yield return new WaitForSeconds(enemyfr);
            }
            else if (laneno == 7)
            {
                Instantiate(enemy, new Vector3(-40, -0.45f, L2), Quaternion.Euler(0, 90, 0));
                Instantiate(enemy, new Vector3(-40, -0.45f, L3), Quaternion.Euler(0, 90, 0));
                yield return new WaitForSeconds(enemyfr);
            }
            else if (laneno == 8)
            {
                Instantiate(enemy, new Vector3(-40, -0.45f, L3), Quaternion.Euler(0, 90, 0));
                Instantiate(enemy, new Vector3(-40, -0.45f, L4), Quaternion.Euler(0, 90, 0));
                yield return new WaitForSeconds(enemyfr);
            }
            else if (laneno == 9)
            {
                Instantiate(enemy, new Vector3(-40, -0.45f, L1), Quaternion.Euler(0, 90, 0));
                Instantiate(enemy, new Vector3(-40, -0.45f, L2), Quaternion.Euler(0, 90, 0));
                yield return new WaitForSeconds(enemyfr);
            }
            else if (laneno == 10)
            {
                Instantiate(enemy, new Vector3(-40, -0.45f, L1), Quaternion.Euler(0, 90, 0));
                Instantiate(enemy, new Vector3(-40, -0.45f, L4), Quaternion.Euler(0, 90, 0));
                yield return new WaitForSeconds(enemyfr);
            }
        }
    }
}
