using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetMousePosition : MonoBehaviour
{
    public static Vector2 PosicaoAtualDoMouse;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseposition = Input.mousePosition;
        mouseposition = Camera.main.ScreenToWorldPoint(mouseposition);
        float posicaoaux_x = mouseposition.x - transform.position.x;
        float posicaoaux_y = mouseposition.y - transform.position.y;
        Vector2 direcao = new Vector2(posicaoaux_x, posicaoaux_y);
        PosicaoAtualDoMouse = direcao;
    }
}
