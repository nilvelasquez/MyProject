using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Transform attackPosition;
    GameObject targetGameObject;
    private float speed = 0.75f;
    Vector2 direction;
    public Rigidbody2D rigid;
    private float inverseMoveTime;

    protected virtual void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        targetGameObject = GameObject.Find("Camarera");
        //inverseMoveTime = 1f / moveTime;
    }
    private void Update()
    {
        attackPosition = targetGameObject.transform;
        direction = new Vector2(attackPosition.position.x - transform.position.x, attackPosition.position.y - transform.position.y);
    }

    //Calculamos la dirección hacia donde se tiene que mover el monstruo para atacar al jugador
    private void FixedUpdate()
    {
        rigid.velocity = direction * speed;        
    }

    //Función que llamamos cuando entra en contacto con el jugador
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == targetGameObject)
        {
            Debug.Log("Game Over");
            Application.Quit();
        }
    }
}