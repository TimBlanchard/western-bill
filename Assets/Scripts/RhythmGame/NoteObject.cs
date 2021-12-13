using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;

    public KeyCode keyToPress;
	public GameObject hitEffect;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            if (canBePressed)
            {
                gameObject.SetActive(false);
				
                GameManager.instance.NoteHit();
				Instantiate(hitEffect, new Vector3(transform.position.x, transform.position.y, transform.position.z-0.1f), hitEffect.transform.rotation);
            }
        }
		if(GameManager.instance.succeedGame)
		{
			Destroy(gameObject);
		}
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = true;
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = false;
            
            GameManager.instance.NoteMissed();
        }
    }
}
