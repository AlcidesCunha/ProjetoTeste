using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rig;
    private Vector2 moveController;
    // Start is called before the first frame update

    public void setSpeed(float velocidade)
    {
        speed = velocidade;
    }

    void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movimento = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        moveController = movimento * speed;   
    }

    void FixedUpdate()
    {
        rig.MovePosition(rig.position + moveController * Time.fixedDeltaTime);
    }
}
