using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    bool enabled = false;

    // Transform for the drone rotation lock
    Transform t;

    // Start is called before the first frame update
    void Start(){
        t = transform;
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Q))
        {
            t.eulerAngles = new Vector3 (-90, 0, 0);
        }
        if(Input.GetKeyDown(KeyCode.E))
        {
            t.eulerAngles = new Vector3 (-90, 90, 0);
        }
    }
}
