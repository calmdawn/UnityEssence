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
        //������� �������� �Է°��� �����Ͽ� ����
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");

        //���� �̵� �ӵ��� �Է°��� �̵� �ӷ��� ����� ����
        float xSpeed = xInput * speed;
        float zSpeed = zInput * speed;

        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        playerRigidbody.velocity = newVelocity;

        //if (Input.GetKey(KeyCode.UpArrow)) // ��
        //{
        //    playerRigidbody.AddForce(0f, 0f, speed);
        //}
        //else if (Input.GetKey(KeyCode.DownArrow)) // ��
        //{
        //    playerRigidbody.AddForce(0f, 0f, -speed);
        //}
        //else if (Input.GetKey(KeyCode.LeftArrow)) // ��
        //{
        //    playerRigidbody.AddForce(-speed, 0f, 0f);
        //}
        //else if (Input.GetKey(KeyCode.RightArrow)) // ��
        //{
        //    playerRigidbody.AddForce(speed, 0f, 0f);
        //}

    }

    public void Die() {
        gameObject.SetActive(false);
    }

}

