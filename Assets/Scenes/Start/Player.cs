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
        [! �¿��̵� �ڵ� !]
        //�� �����Ӹ��� �� ������ �������� Ȯ��
        if (Input.GetKeyDown(KeyCode.LeftArrow)) //Ű ������
        {
            transform.position += Vector3.left * Time.deltaTime * 10;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * Time.deltaTime * 10;
        }
        */



        float x = Input.GetAxisRaw("Horizontal"); //�� ���̱⶧���� ȣ����Ż
        float y = Input.GetAxisRaw("Vertical"); //����

        //transform.position += new Vector3(x, y, 0f) * Time.deltaTime * 10;
        transform.Translate(new Vector3(x, y, 0f) * Time.deltaTime * 10); 
            


    }
}
