using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shapeRotate : MonoBehaviour
{
    [SerializeField] KeyCode leftRotate;
    [SerializeField] KeyCode rightRotate;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(leftRotate)&&this.transform.position.z == -2)
        {
            transform.Rotate(0, 0,-45);
        }
        if (Input.GetKeyDown(rightRotate)&&this.transform.position.z == -2)
        {
            transform.Rotate(0, 0,45);
        }
       
    }
}
