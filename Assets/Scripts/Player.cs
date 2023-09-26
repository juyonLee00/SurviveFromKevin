using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    float hAxcis;
    float vAxcis;
    bool rDown;

    Vector3 moveVec;
    Animator anim;
    // Start is called before the first frame update
    void Awake()
    {
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        hAxcis = Input.GetAxisRaw("Horizontal");//Axis  값을 정수로 반환하는 함수
        vAxcis = Input.GetAxisRaw("Vertical");
        rDown = Input.GetButton("Run");

        moveVec = new Vector3(hAxcis, 0, vAxcis).normalized;//움직임 구현normalized 방향값이 1로 보정

        transform.position += moveVec * speed * (rDown ? 2f : 1f) * Time.deltaTime;

        anim.SetBool("isWalk", moveVec != Vector3.zero);
        anim.SetBool("isRun", rDown);

        transform.LookAt(transform.position + moveVec);

    }
}
