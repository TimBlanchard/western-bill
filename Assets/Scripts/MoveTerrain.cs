using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTerrain : MonoBehaviour
{
    public Vector3 Direction;
    // public float Speed;

    private Global GlobalRef;

    // Start is called before the first frame update
    void Start()
    {
        GlobalRef = GameObject.FindObjectOfType<Global>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(GlobalRef.Speed * Direction * Time.deltaTime);
    }
}
