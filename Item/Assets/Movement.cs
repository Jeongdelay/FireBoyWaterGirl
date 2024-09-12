using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float movePower = 2f;
    public float jumpPower = 2f;
    public int PlayerCoin = 0;

    Rigidbody2D rigid;

    Vector3 movement;
    bool isJumping = false;

    // Start is called before the first frame update
    void Start()
    {
        rigid = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            isJumping = true;
        }
    }

    private void FixedUpdate()
    {
        Move();
        Jump();
    }

    void Move()
    {
        Vector3 moveVelocity = Vector3.zero;

        if (Input.GetAxisRaw("Horizontal") < 0 )
        {
            moveVelocity = Vector3.left;
        }

        else if (Input.GetAxisRaw("Horizontal") > 0)
        {
            moveVelocity = Vector3.right;
        }

        transform.position += moveVelocity * movePower * Time.deltaTime;

    }
    void Jump()
    {
        if (!isJumping)
            return;
        rigid.velocity = Vector2.zero;

        Vector2 jumpVelocity = new Vector2(0, jumpPower);
        rigid.AddForce(jumpVelocity, ForceMode2D.Impulse);

        isJumping = false;
    }

    public void PC()
    {
        PlayerCoin ++;
        print(PlayerCoin);
    }
    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.tag == "Coin")
    //    {
    //        PlayerCoin ++;
    //        Destroy(other.gameObject, 0f);

    //        print(PlayerCoin);
    //    }
    //}
}