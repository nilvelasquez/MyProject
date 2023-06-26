using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    Transform attackPosition;
    GameObject targetGameObject;
    PlayerStats targetPlayer;
    //private float speed = 1f;
    [SerializeField] int health;
    [SerializeField] int damage = 1;
    Vector2 direction;
    public Rigidbody2D rigid;
    private float inverseMoveTime;
    public float moveTime = 0.1f;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
        targetGameObject= GameObject.Find("Camarera");
        inverseMoveTime = 1f / moveTime;
    }

    //Calculamos la dirección hacia donde se tiene que mover el monstruo para atacar al jugador
    private void FixedUpdate()
    {
        /*attackPosition = targetGameObject.transform;
        direction = attackPosition.position - transform.position;
        rigid.velocity = direction * speed;*/
        int xDir = 0;
        int yDir = 0;
        bool hor = false;
        bool ver = false;
        attackPosition = targetGameObject.transform;
        if (Mathf.Abs(attackPosition.position.x - transform.position.x)>float.Epsilon)
        {
            hor = true;
        }
        if (Mathf.Abs(attackPosition.position.y - transform.position.y) > float.Epsilon)
        {
            ver = true;
        }
        if(ver)
        {
            xDir = 0;
            yDir = attackPosition.position.y > transform.position.y ? 1 : -1;
            Vector3 start = transform.position;
            Debug.Log("startV" + start);
            Vector3 end = start + new Vector3(xDir, yDir, 0f);
            Debug.Log("endV" + end);
            float sqrRemainingDistance = (transform.position - end).sqrMagnitude;
            while (sqrRemainingDistance > float.Epsilon)
            {
                Vector3 newPosition = Vector3.MoveTowards(rigid.position, end, inverseMoveTime * Time.deltaTime);
                Debug.Log("newPosV"+ newPosition);
                rigid.MovePosition(newPosition);
                sqrRemainingDistance = (transform.position - end).sqrMagnitude;
            }
        }
        if (hor)
        {
            xDir = attackPosition.position.x > transform.position.x ? 1 : -1;
            yDir = 0;
            Vector3 start = transform.position;
            Debug.Log("startV" + start);
            Vector3 end = start + new Vector3(xDir, yDir, 0f);
            Debug.Log("endV" + end);
            float sqrRemainingDistance = (transform.position - end).sqrMagnitude;
            while (sqrRemainingDistance > float.Epsilon)
            {
                Vector3 newPosition = Vector3.MoveTowards(rigid.position, end, inverseMoveTime * Time.deltaTime);
                Debug.Log("newPosV" + newPosition);
                rigid.MovePosition(newPosition);
                sqrRemainingDistance = (transform.position - end).sqrMagnitude;
            }
        }
    }

    //Función que llamamos cuando entra en contacto con el jugador
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject == targetGameObject)
        {
            Damage();
        }
    }

    //Función que llamamos cuando hace daño al jugador
    private void Damage()
    {
        if (targetPlayer == null)
        {
            targetPlayer = targetGameObject.GetComponent<PlayerStats>();
        }
        targetPlayer.TakeDamage(damage);
    }
}