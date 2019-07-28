using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMousePosition : MonoBehaviour
{


    public static Vector2 posicaoAtualDoMouse;

    public GameObject bullet;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //Vector3 mouseposition = -Vector3.one;
        //mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0,0,5f));
        //Vector2 direcao = mouseposition;
        //posicaoAtualDoMouse = direcao;

        if (Input.GetButtonDown("Fire1"))
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.LookAt(mousePosition);
            Instantiate(bullet, transform.position, transform.rotation);
            posicaoAtualDoMouse = new Vector2(mousePosition.x,mousePosition.y);
        }

    }
}
