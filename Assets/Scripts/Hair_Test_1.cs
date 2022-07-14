using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ATTRIBUTE REQUIREMENT OF A MESHFILTER
[RequireComponent(typeof(MeshFilter))]
public class Hair_Test_1 : MonoBehaviour
{ 
    
   
         // CREATE VARIABLE / TYPE MESH
        Mesh mesh;
        
        // VECTOR ARRAY 
        Vector3[] vertices;
 
        // SIZE SETTINGS
        public int xSize = 20;
        public int zSize = 20;   
        public int ySize = 20;  

        // LOCATIONS SETTINGS
        public float xLocation= 1f;
        public float zLocation= 0f;
       
        // BEHAVIOUR SETTINGS
        public float offset = 0.2f;
        public float amplitude = 0.5f;
        public float speed = 5f;
    

// ________________________________________________________________________________________________//
// ______________________________________ START VOID______________________________________________//

    void Start()
    {
        // CREATE MESH
        mesh = new Mesh();
        GetComponent<MeshFilter>().mesh = mesh;
      
        CreateShape();
       // UpdateMesh();


    }
    

// ________________________________________________________________________________________________//
// ___________________________CREATER SHAPE - PASTE TRIANGLES HERE________________________________//

    void CreateShape () 
    {
        // CREATE VERTICES // SYNTAX SPEZIFIZIERT ELEMENTE IN ARRAY
       vertices = new Vector3[(xSize+1)*(zSize + 1)*(ySize+1)];


  

    }


// ________________________________________________________________________________________________//
// _____________________________DRAW SPHERES - ONDRAWGIZMOS________________________________________//

    private void OnDrawGizmos() 
    {
        if (vertices == null)
        return;
        {
            
        }
        for (int i = 0; i < vertices.Length; i++)
        {
            Gizmos.DrawSphere(vertices[i], .1f);
        }
    }

// ________________________________________________________________________________________________//
// _____________________________FUNCTION FOR THE SINE MOVEMENT____________________________________//



    private void Update() {

    //vertices.Initialize();
    mesh.Clear();
    mesh.RecalculateNormals();
    mesh.vertices = vertices;


        int i = 0;
        
   for ( int x = 0; x <= xSize; x++)
          { for (int z = 0; z < zSize; z++)
          {for (int h = 0; h < ySize; h++)
          {
              
          
              
              // VERTICES INDEX, POSITIONS, MOVEMENTS
                float y = Mathf.Sin((Time.time * speed + i + offset)) * amplitude ;
            
              vertices[i] = new Vector3(x+xLocation,y+h,z+zLocation);
              i++; 
              
              }
            }  
          } 
    }
}
