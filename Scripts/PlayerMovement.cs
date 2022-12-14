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
      //Change AddForce to a timed rb.velocity, then have it reset to the default. it should be gradual rather than instant, unless blink is wanted.
      //if blink is wanted, reflect speed lines in animation for when blink is done. 
      rb.AddForce(dir * (speed * 100));
      Debug.Log("Dash Activated");
    }

    void Update()
    {
  
      mx = Input.GetAxisRaw("Horizontal");
      my = Input.GetAxisRaw("Vertical");
      dir = new Vector2(mx, my);
      if(Input.GetKeyDown(KeyCode.LeftShift)) dash();
    }
}

