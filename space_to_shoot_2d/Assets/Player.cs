using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour {

    private float speed = 7f;
    private Rigidbody2D rb2d;
    public Transform firePoint;
    public Transform FP1;
    public Transform FP2;
    public GameObject bulletPrefab;
    private float bulletSpeed = 10f;
    private float cooldown = 0.5f;
    private float nextFire = 0f;

    void Start () {
      rb2d = GetComponent<Rigidbody2D> ();
    }
	
    void Update () {
      UpdateMotion();
      ProcessBulletSpwan();
    }

    private void UpdateMotion() {
        Vector3 pos = transform.position;

        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }

        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }

        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }

        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }

        transform.position = pos;
    }
    
    private void ProcessBulletSpwan() {
      if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Mouse0)) && Time.time > nextFire) {
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Rigidbody2D re = bullet.GetComponent<Rigidbody2D>();
        re.velocity = firePoint.up * bulletSpeed;
        nextFire = Time.time + cooldown;
      }

      if ((Input.GetKey(KeyCode.Q)) && Time.time > nextFire * 1.5)
      {
        GameObject bullet1 = Instantiate(bulletPrefab, FP1.position,  FP1.rotation);
        GameObject bullet2 = Instantiate(bulletPrefab, FP2.position, FP2.rotation);
        Rigidbody2D re1 = bullet1.GetComponent<Rigidbody2D>();
        Rigidbody2D re2 = bullet2.GetComponent<Rigidbody2D>();
        re1.velocity = FP1.up * bulletSpeed;
        re2.velocity = FP2.up * bulletSpeed;
        nextFire = Time.time + cooldown;
      }
    }
}
