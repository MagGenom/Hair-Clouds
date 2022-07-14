using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.VFX;

public class GravPullMag : MonoBehaviour
{
    [SerializeField] VisualEffect vfx;
    [SerializeField] GameObject posTrans;

    //Vector3 position;

    //float x = -2;
    //float y = 2;
    //float z = 0;
// ___________________________________________________________

    void Start()
    {
        //position = new Vector3(x,y,z);
        //position = posTrans.Transform;
    }

// ___________________________________________________________

    void Update()
    {
        vfx.SetVector3("ForcePosition", posTrans.transform.position);
    }
}
