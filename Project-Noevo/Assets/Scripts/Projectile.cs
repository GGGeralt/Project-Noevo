using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D rigid;

    public Vector2 direction;
    public int speed;

    private void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        rigid.AddForce(direction * speed, ForceMode2D.Impulse);
        Debug.Log("IM ENADBLED?!?!");
    }
}
