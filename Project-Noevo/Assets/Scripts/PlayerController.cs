using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed;
    Rigidbody2D rb;

    Vector2 movementVector;
    float horizontal, vertical;

    [SerializeField]
    public ProjectileSkill skill;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        GetInput();
        if(Input.GetMouseButtonDown(1))
        {
            skill.UseSkill();
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = movementVector * Player.Instance.Speed.value;
    }

    void GetInput()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxisRaw("Vertical");
        movementVector = new Vector2(horizontal, vertical);
    }
}
