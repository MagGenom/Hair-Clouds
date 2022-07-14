using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.VFX;

public class AttractForce : MonoBehaviour
{
        [SerializeField] VisualEffect vfx;
        float intensity = 2;
    
 // _____________________________________________________________________________________________________________

    void Start()
    {
      
    }

 // _____________________________________________________________________________________________________________


    void Update()
    {
         vfx.SetFloat("AttractForce", intensity);

    }
}
