using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpeedContrastElement : MonoBehaviour
{
    public Vector3 Direction;
    private Global GlobalRef;
    
    [SerializeField]
    private float speed;
    
    // Start is called before the first frame update
    void Start()
    {
        GlobalRef = GameObject.FindObjectOfType<Global>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GameManager.instance.succeedGame){
            transform.Translate(speed * Direction * Time.deltaTime);
        }    
    }
}
