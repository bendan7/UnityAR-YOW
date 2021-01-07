using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        // this.transform.Rotate = new Quaternion(transform.rotation.x, transform.rotation.y + 0.01f, transform.rotation.z, transform.rotation.w);
        transform.Rotate(0, 0.5f, 0, Space.Self);

    }
    // Update is called once per frame
    void Update()
    {
    }
}
