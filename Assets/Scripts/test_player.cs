using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test_player : MonoBehaviour
{
    public float MoveSpeed = 10f;

    void Update()
    {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(0, 0, v) * MoveSpeed * Time.deltaTime);
        transform.Rotate(new Vector3(0, h, 0));

    }
}
