using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introducao : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("start");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("update");
    }

    void Awake()
    {
        Debug.Log("awake");
    }

    void LateUpdate()
    {
        Debug.Log("lateUpdate");
    }
    void FixedUpdate()
    {
        Debug.Log("FixedUpdate");
    }
}
