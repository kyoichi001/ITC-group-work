using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public Rigidbody rigidbody;
    public Vector3 velocity;

    // Start is called before the first frame update
    //物体が生成されたときに１回呼ばれる
    void Start()
    {
        rigidbody.AddForce(velocity);
    }

    // Update is called once per frame
    //毎フレーム呼ばれる
    void Update()
    {

    }



}
