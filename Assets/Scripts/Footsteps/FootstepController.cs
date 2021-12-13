using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepController : MonoBehaviour
{

    public int Count = 10;
    public float Distance = 1.0f;
    public GameObject Footstep;
    public Harmonica harmonica;

    private Footstep[] steps;

    private Coroutine HideDelay;

    void Start()
    {

        steps = new Footstep[Count];
        for (int i = 0; i < Count; i++)
        {
            GameObject footstep = Instantiate<GameObject>(Footstep,transform);
            steps[i] = footstep.GetComponent<Footstep>();
            footstep.transform.position = new Vector3(Mathf.Sin(Distance*i*10.0f)*.2f,Footstep.transform.position.y,Distance*i);
        }
        harmonica.OnHarmonicaPlay += OnPlayNote;
        
        
    }

    void OnPlayNote() {
        Debug.Log("OnPlayNote");

        for (int i = 0; i < steps.Length; i++)
        {
            steps[i].AlphaTo(1f, 1f);
        }

        if(HideDelay != null) {
            StopCoroutine(HideDelay);
            HideDelay = null;
        }
        HideDelay = StartCoroutine(HideSteps());
    }

    private IEnumerator HideSteps() {

        Debug.Log("HidesTEPS before");
        yield return new WaitForSeconds(5);
        Debug.Log("HidesTEPS after");

        for (int i = 0; i < steps.Length; i++)
        {
            steps[i].AlphaTo(0f, 1f);
        }
    }

}
