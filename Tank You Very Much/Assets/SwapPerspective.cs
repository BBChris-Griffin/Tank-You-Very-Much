using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwapPerspective : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.C))
        {
            this.transform.rotation = new Quaternion(transform.rotation.x, transform.rotation.y, transform.rotation.z + 180, transform.rotation.w);
        }
    }
}
