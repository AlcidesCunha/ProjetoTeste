using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMousePosition : MonoBehaviour
{
    public static Vector2 posicaoAtualDoMouse;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 mouseposition = -Vector3.one;
        mouseposition = Camera.main.ScreenToWorldPoint(Input.mousePosition + new Vector3(0,0,5f));
        Vector2 direcao = mouseposition;
        posicaoAtualDoMouse = direcao;
    }
}
