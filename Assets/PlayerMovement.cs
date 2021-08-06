using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed=1f;

    private Vector3 _moveDir;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float  zInput= Input.GetAxisRaw("Vertical");

        _moveDir = new Vector3(xInput, 0, zInput);
        transform.Translate(_moveDir * (speed * Time.deltaTime));
        
    }
}
