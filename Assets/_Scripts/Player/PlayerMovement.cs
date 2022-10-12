using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    protected Rigidbody2D rg2d;
    public Vector2 velocity = new Vector2(0f, 0f);
    public float pressHorizontal = 0f;
    public float pressVertical = 0f;
    public float speedUp = 0.25f;
    public float speedDown = 0.25f;
    public float speedMax = 15f;
    public float speedHorizontal = 3f;
    public bool autoRun = false;

    private void Awake()
    {
        rg2d = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        this.pressHorizontal = Input.GetAxis("Horizontal");
        this.pressVertical = Input.GetAxis("Vertical");
        if (autoRun) this.pressVertical = 1;
    }

    private void FixedUpdate()
    {
        this.UpdateSpeed();
    }

    public void UpdateSpeed()
    {
        this.velocity.x = this.pressHorizontal * speedHorizontal;

        UpdateSpeedUp();
        UpdateSpeedDown();


        this.rg2d.MovePosition(this.rg2d.position + this.velocity * Time.fixedDeltaTime);
    }

    public void UpdateSpeedUp()
    {
        if (this.pressVertical <= 0) return;

        this.velocity.y += speedUp;

        if (this.velocity.y >= this.speedMax) this.velocity.y = this.speedMax;

        if (this.transform.position.x >= 8 || this.transform.position.x <= -8)
        {
            this.velocity.y -= 0.5f;
            if (this.velocity.y <= 10f) this.velocity.y = 10f;
        }

    }

    public void UpdateSpeedDown()
    {
        if (this.pressVertical != 0) return;

        this.velocity.y -= speedDown;
        if (this.velocity.y <= 0) this.velocity.y = 0;
    }
}
