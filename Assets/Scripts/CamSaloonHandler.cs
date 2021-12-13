using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using DG.Tweening;

public class CamSaloonHandler : MonoBehaviour
{
    //Assign your ball in the inspector
    public Transform target;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(target);
        Vector3 cursorPos = Camera.main.ScreenToWorldPoint( new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.nearClipPlane));
        transform.position = new Vector3(cursorPos.x, cursorPos.y, transform.position.z);
    }
}
