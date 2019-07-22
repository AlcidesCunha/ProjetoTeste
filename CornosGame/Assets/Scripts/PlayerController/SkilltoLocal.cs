using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkilltoLocal : MonoBehaviour
{
    private Rigidbody2D rig;
    public float speed;
    private float lifeTime;
    private Transform target;
    public GameObject auxTarget;
    private bool isInstantied = false;
    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
        lifeTime = 5;
    }

    // Update is called once per frame
    void Update()
    {
        //Tempo de vida do projetil
       
        lifeTime -= Time.deltaTime;
        if (lifeTime <= 0)
        {
            Destroy(this.gameObject);
            Destroy(GameObject.FindGameObjectWithTag("Target"));
            isInstantied = false;
        }

        //target.position = GetMousePosition.posicaoAtualDoMouse;
        /*Vector3 mouseposition = Input.mousePosition;
        Vector2 local_alvo = Camera.main.ScreenToWorldPoint(mouseposition); //pegando a posição atual do ponteiro do mouse
        transform.LookAt(local_alvo);
        target.transform.position = local_alvo;*/
        

    }
        
    private void FixedUpdate()
    {
        if(!isInstantied)
        {
            Instantiate(auxTarget, GetMousePosition.posicaoAtualDoMouse, Quaternion.identity);
            isInstantied = true;
        }
        //A posição do mouse a ser pega não está funcionando.
        Vector2 direcao = auxTarget.transform.position;
        Debug.Log(direcao);
        rig.velocity = direcao.normalized * speed;
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
