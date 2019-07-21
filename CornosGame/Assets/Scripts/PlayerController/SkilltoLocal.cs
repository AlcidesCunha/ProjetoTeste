using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkilltoLocal : MonoBehaviour
{
    private Rigidbody2D rig;
    public float moveSpeed;
    private float lifeTime;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        lifeTime = 5;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 local_alvo = GetMousePosition.PosicaoAtualDoMouse; //pegando a posição atual do ponteiro do mouse
        transform.LookAt(local_alvo);
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        lifeTime -= Time.deltaTime;
        if(lifeTime <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}
