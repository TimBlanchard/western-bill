using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarmonicaHandler : MonoBehaviour
{
    [SerializeField]
    private Transform cameraTransform;
    public AudioSource audioDatas;
    
    public GameObject[] ObjPrefabs;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.H))
        {
            audioDatas.Play();
        }
    }
}
