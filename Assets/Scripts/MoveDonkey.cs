using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class MoveDonkey : MonoBehaviour
{
    public Vector3 Direction;
    public int speed = 3;
    public bool isRunning = false;
    private Animator animator;
    
    [SerializeField]
    private CinemachineFreeLook playerCam;
    [SerializeField]
    private CinemachineVirtualCamera donkeyCam;

    // Start is called before the first frame update
    void Start()
    { 
        animator = GetComponentInChildren<Animator>();
        playerCam.Priority = 11;
        donkeyCam.Priority = 10;
      StartCoroutine(WaiterRunDelay());
    }

    // Update is called once per frame
    void Update()
    {
      if(isRunning) {
		    transform.Translate( speed * Direction * Time.deltaTime);
      }
    }

        IEnumerator WaiterRunDelay()
    {
        yield return new WaitForSeconds(18);
        animator.SetBool("isRunning", true);
        yield return new WaitForSeconds(.2f);
        isRunning = true;
        playerCam.Priority = 0;
        yield return new WaitForSeconds(7);
        playerCam.Priority = 11;
    }
}
