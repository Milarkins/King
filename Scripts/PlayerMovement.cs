using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    float mx, my;

    void Start() => rb = GetComponent<Rigidbody2D>();
    void FixedUpdate() => rb.velocity = new Vector2(mx, my) * speed;

    void Update()
    {
      mx = Input.GetAxisRaw("Horizontal");
      my = Input.GetAxisRaw("Vertical");
    }
}
