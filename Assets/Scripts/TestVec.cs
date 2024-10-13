using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestVec : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector4 vec = new Vector4(1f, 2f, 3f, 4f);
        Vector3 v = vec;
        Debug.Log(v);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
