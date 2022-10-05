using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour
{
    public GameObject player, bullet;
    private Vector3 v3Pos;
    private float angle, distance = 0.28f;

    void Start() => transform.parent = null;

    void Update()
    {
      //rotation
      v3Pos = Input.mousePosition;
      v3Pos.z = (player.transform.position.z - Camera.main.transform.position.z);
      v3Pos = Camera.main.ScreenToWorldPoint(v3Pos);
      v3Pos = v3Pos - player.transform.position;
      angle = Mathf.Atan2(v3Pos.y, v3Pos.x) * Mathf.Rad2Deg;
      if(angle < 0.0f) angle += 360.0f;
      transform.localEulerAngles = new Vector3(0,0, angle);

      float xPos = Mathf.Cos(Mathf.Deg2Rad * angle) * distance;
      float yPos = Mathf.Sin(Mathf.Deg2Rad * angle) * distance;
      transform.localPosition = new Vector3(player.transform.position.x + xPos * 4, player.transform.position.y + yPos * 4, 0);

      //shooting
      if(Input.GetKeyDown(KeyCode.Mouse0))
      {
        Instantiate(bullet, transform.position, transform.rotation);
      }
    }
}
