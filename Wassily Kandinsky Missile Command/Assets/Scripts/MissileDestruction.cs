using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileDestruction : MonoBehaviour {

    public Transform MissileExplosionOBJ;

     void OnMouseDown()
    {
        Destroy(gameObject);
        Instantiate(MissileExplosionOBJ, transform.position, MissileExplosionOBJ.rotation);
        
    }

}

    
       