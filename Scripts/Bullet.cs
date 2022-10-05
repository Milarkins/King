using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour
{
  public float speed = 10.0f;

  void Update()
  {
    GetComponent<Rigidbody2D>().velocity = transform.right * speed;
    StartCoroutine(Clean());
  }

  void OnCollisionEnter2D(Collision2D col)
  {
    if(col.gameObject.tag == "Enemy")
    {
      col.gameObject.GetComponent<Health>().MinusHP(1);
      Destroy(gameObject);
    }
    if(col.gameObject.layer == 3) Destroy(gameObject);
  }

  IEnumerator Clean()
  {
    yield return new WaitForSeconds(2.0f);
    Destroy(gameObject);
  }
}
