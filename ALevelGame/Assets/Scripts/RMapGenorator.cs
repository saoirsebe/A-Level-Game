using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RMapGenorator : MonoBehaviour
{

    public bool Spawn1;

    // Start is called before the first frame update
    void Start()
    {
        int pickBool = Random.Range(0, 1);
        
        if (pickBool == 0)
        {
            Spawn1 = true;
        }
        else
        {
            Spawn1 = false;
        }

    }

    
}
