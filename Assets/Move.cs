using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] Rigidbody2D rigidbody2d;
    [SerializeField] new SpriteRenderer renderer;

    [SerializeField] float speed = 10;
    [SerializeField] float jumpPower = 15;

    float _xForce;
    float _yForce;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Update()
    {
        _xForce = Input.GetAxisRaw("Horizontal") * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigidbody2d.linearVelocityY = jumpPower;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rigidbody2d.linearVelocity = new Vector2(_xForce, rigidbody2d.linearVelocityY);

        if (_xForce != 0)
        {
            renderer.flipX = _xForce < 0;
        }
    }
}

