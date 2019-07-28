using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillShot : MonoBehaviour
{
    public static Vector2 posicaoAtualDoMouse;

    public GameObject bullet;

    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1")) //Se clicou
        {
            Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.LookAt(mousePosition);
            Instantiate(bullet, transform.position, transform.rotation);
            posicaoAtualDoMouse = new Vector2(mousePosition.x,mousePosition.y);
        }

    }
}
