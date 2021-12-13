using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class Clickable : MonoBehaviour
{
    public void OnMouseEnter()
    {
        Debug.Log("hoo");
        CursorHandler.instance.Clickable();
    }
    public void OnMouseExit()
    {
        CursorHandler.instance.Default();
    }
}
