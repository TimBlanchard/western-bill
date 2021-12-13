using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorHandler : MonoBehaviour
{
    public static CursorHandler instance;
    private SpriteRenderer spriteR;
    //public Sprite defaultCursorSP, clickableCursorSP;
    public Texture2D defaultCursor, clickableCursor;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    void Start()
    {
        //Cursor.visible = false;
        //spriteR = gameObject.GetComponent<SpriteRenderer>();
        Default();
    }
    // Update is called once per frame
    void Update()
    {
     Vector3 cursorPos = Camera.main.ScreenToWorldPoint( new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.3f));
     transform.position = cursorPos;
    }

    public void Clickable()
    {
        Cursor.SetCursor(clickableCursor, Vector2.zero, CursorMode.Auto);
        //spriteR.sprite = clickableCursorSP;
    }
    public void Default()
    {
        Cursor.SetCursor(defaultCursor, Vector2.zero, CursorMode.Auto);
        //spriteR.sprite = defaultCursorSP;
    }
}
