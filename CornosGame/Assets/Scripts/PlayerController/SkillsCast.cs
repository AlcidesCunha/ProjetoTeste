using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsCast : MonoBehaviour
{
    // Start is called before the first frame update

    private void Skill1()
    {
        Vector2 local_alvo = GetMousePosition.PosicaoAtualDoMouse; //pegando a posição atual do ponteiro do mouse
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Z))
        {

        }
    }
}
