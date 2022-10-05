using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;
    float mx, my;

    Vector2 dir;
    

    void Start() => rb = GetComponent<Rigidbody2D>();
    void FixedUpdate() => rb.velocity = dir * speed;

    void dash() 
    { 
      rb.AddForce(dir * (speed * 100));
      Debug.Log("BOOM");
    }

    void Update()
    {
  
      mx = Input.GetAxisRaw("Horizontal");
      my = Input.GetAxisRaw("Vertical");
      dir = new Vector2(mx, my);
      if(Input.GetKeyDown(KeyCode.LeftShift)) dash();
    }
}

