using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTerrain : MonoBehaviour
{
    public Vector3 Direction;

    private Global GlobalRef;

    // Start is called before the first frame update
    void Start()
    {
        GlobalRef = GameObject.FindObjectOfType<Global>();
    }

    // Update is called once per frame
    void Update()
    {
		if(!GameManager.instance.succeedGame){
		transform.Translate(GameManager.instance.gameSpeed * GlobalRef.stepMultiplicatorTerrain * Direction * Time.deltaTime);
		} else {
		transform.Translate(GameManager.instance.gameSpeed * .05f * Direction * Time.deltaTime);
		}
    }
}
