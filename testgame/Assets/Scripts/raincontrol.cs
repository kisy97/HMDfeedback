using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raincontrol : MonoBehaviour
{
    
    public ParticleSystem particleObject; //파티클시스템
    // Start is called before the first frame update
    void Start()
    {
        particleObject = GetComponent<ParticleSystem>();
        particleObject.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Z))
        {
            Debug.Log("Z");
            particleObject.Play();
        }

        else if (Input.GetKeyDown(KeyCode.X))
        {
            Debug.Log("X");
            particleObject.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        }

        
    }
    
}
