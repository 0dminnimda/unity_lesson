using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject prefab;
    public float destroyTime = 1f;
    public float waitTime = 0.5f;


    // Update is called once per frame
    void FixedUpdate()
    {
        StartCoroutine(InstantiateAndWait());
    }

    IEnumerator InstantiateAndWait()
    {
        yield return new WaitForSeconds(waitTime);
        GameObject obj = Instantiate(prefab, transform.position, transform.rotation);
        Destroy(obj, destroyTime);
    }
}
