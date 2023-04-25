using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;
    public float speed = 8f;
    // Start is called before the first frame update
    void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //수평축과 수직촉의 입력값을 감지하여 저장
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //실제 이동 속도를 입력값과 이동 속력을 사용해 결정
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        playerRigidbody.velocity = newVelocity;

        //if (Input.GetKey(KeyCode.UpArrow)) // 상
        //{
        //    playerRigidbody.AddForce(0f, 0f, speed);
        //}
        //else if (Input.GetKey(KeyCode.DownArrow)) // 하
        //{
        //    playerRigidbody.AddForce(0f, 0f, -speed);
        //}
        //else if (Input.GetKey(KeyCode.LeftArrow)) // 좌
        //{
        //    playerRigidbody.AddForce(-speed, 0f, 0f);
        //}
        //else if (Input.GetKey(KeyCode.RightArrow)) // 우
        //{
        //    playerRigidbody.AddForce(speed, 0f, 0f);
        //}

    }

    public void Die() {
        gameObject.SetActive(false);
    }

}

