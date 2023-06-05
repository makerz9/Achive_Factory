using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    ////public Camera came;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("Start()");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(came.transform);
        //Debug.Log("Update()");  

        /*
        [! 좌우이동 코드 !]
        //매 프레임마다 이 값들이 들어오는지 확인
        if (Input.GetKeyDown(KeyCode.LeftArrow)) //키 누를때
        {
            transform.position += Vector3.left * Time.deltaTime * 10;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime * 10;
        }
        */



        float x = Input.GetAxisRaw("Horizontal"); //좌 우이기때문에 호리존탈
        float y = Input.GetAxisRaw("Vertical"); //세로

        //transform.position += new Vector3(x, y, 0f) * Time.deltaTime * 10;
        transform.Translate(new Vector3(x, y, 0f) * Time.deltaTime * 10); 
            


    }
}
