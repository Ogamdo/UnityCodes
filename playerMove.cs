using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{   //아래 코드들은 3주차 코드와 ppt 등 정지영 교수님의 자료들을 참조했습니다.
    public float speed;
    public Transform player;
    public float speedRot;

    float x, y, z;

    // Start is called before the first frame update
    void Start()
    {
        x = 0;
        y = 0;
        z = 0;

        speed = 3f;
        speedRot = 100f;
        player = GetComponent<Transform>();
        player.position = new Vector3(x, y, z);
        player.rotation = Quaternion.Euler(0, 0, 0); 
    }

    // Update is called once per frame
    void Update()
    {

        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");
        transform.Translate(x * Time.deltaTime * speed, y, z * Time.deltaTime * speed);
        transform.Rotate(0, Input.GetAxis("Mouse X") * Time.deltaTime * speedRot, 0);
    }
}
