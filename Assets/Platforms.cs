using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    public GameObject platformPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(platformPrefab, new Vector3(10, 0, 0), Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
