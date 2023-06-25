using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    /*Transform attackPosition;
    GameObject targetGameObject;
    PlayerStats targetPlayer;
    [SerializeField] float speed;
    [SerializeField] int health;
    [SerializeField] int damage = 1;

    Rigidbody2D rigid;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    //Calculamos la direcci�n hacia donde se tiene que mover el monstruo para atacar al jugador
    private void FixedUpdate()
    {
        Vector2 direction = (attackPosition.position - transform.position);
        rigid.velocity = direction * speed;
    }

    //Funci�n que llamamos cuando entra en contacto con el jugador
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == targetGameObject)
        {
            Damage();
        }
    }

    //Funci�n que llamamos cuando hace da�o al jugador
    private void Damage()
    {
        if (targetPlayer == null)
        {
            targetPlayer = targetGameObject.GetComponent<PlayerStats>();
        }
        targetPlayer.TakeDamage(damage);
    }

    //Funci�n que llamamos cuando se crea un monstruo nuevo para darlo como objetivo al jugador
    public void SetTarget(GameObject target)
    {
        targetGameObject = target;
        attackPosition = target.transform;
    }
    public void TakeDamage(int damage)
    {
        health -= damage;

        if (health < 1)
        {
            Destroy(gameObject);
        }
    }*/
}