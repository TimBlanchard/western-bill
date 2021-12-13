using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpeedController : MonoBehaviour
{
    private ParticleSystem speedPs;
    public int initSpeed;
    public float stepMultiplicator;
    // Start is called before the first frame update
    void Start()
    {
        speedPs = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        var emission = speedPs.emission;
        emission.rateOverTime = initSpeed + GameManager.instance.gameSpeed * stepMultiplicator * Time.deltaTime;

		if(GameManager.instance.succeedGame)
		{
			Destroy(gameObject);
		}
        
    }
}
