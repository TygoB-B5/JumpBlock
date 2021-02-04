using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Renderer : MonoBehaviour
{
    public GameObject prefab;
    private int Spawn = 10;
    public bool needSpawn = false;
    private float count = 0;


    void Start()
    {
        StartCoroutine("spawner");
    }

    IEnumerator spawner()
    {
         float random = Random.Range(0f, 1f);
        Spawn = Spawn + 2;

        if (random >= 0.5f || needSpawn == false)
        {
            Instantiate(prefab, new Vector3(Spawn, 0, 0), Quaternion.identity);
        }
        else
        {
            count = count + 1;
            if (count == 2f)
            {
                Instantiate(prefab, new Vector3(Spawn, 0, 0), Quaternion.identity);
                count = 0f;
            }
        }


        yield return new WaitForSeconds(0.5f);
        StartCoroutine("spawner");

    }


}
