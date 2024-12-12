using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public GameObject bulletPrefab;   
    public Transform bulletSpawnPoint;
    public GameOverScreen ggs;
    public GameOverScreen2 ggs2;
    public MusicManager mm;
    public float bulletSpeed = 10f;        
    public float knockbackForce = 5f;
    public float brakingFactor = 0.95f;

    private Rigidbody2D rb;
    private bool canMove;
    public Transform weaponTransform;
    private bool isBraking = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
        Time.timeScale = 1;
        mm.PlayInGameMusic();
    }

    void Update()
    {
        AimAtMouse();

        if (Time.timeScale == 0)
        {
            return; 
        }

        if (Input.GetMouseButtonDown(0))
        {
            canMove = true;
            //rb.gravityScale = 1;
            Shoot();
            mm.ShootSFX();

        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            isBraking = true;
        }

        if (isBraking)
        {
            rb.velocity = new Vector2(rb.velocity.x * brakingFactor, rb.velocity.y);

            if (Mathf.Abs(rb.velocity.x) < 0.1f)
            {
                rb.velocity = new Vector2(0, rb.velocity.y);  
                isBraking = false;    
            }
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);

        Rigidbody2D bulletRb = bullet.GetComponent<Rigidbody2D>();

        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0; 

        Vector2 direction = (mousePosition - bulletSpawnPoint.position).normalized;

        bulletRb.velocity = direction * bulletSpeed;

        rb.AddForce(-direction * knockbackForce, ForceMode2D.Impulse);
    }

    public void OnTriggerEnter2D(Collider2D touch)
    {
        Debug.Log("Triggered with: " + touch.gameObject.name);
        if (touch.gameObject.CompareTag("Wall"))
        {
            Time.timeScale = 0;
            ggs.ggScreen();
        }
        if (touch.gameObject.CompareTag("Enemy"))
        {
            Time.timeScale = 0;
            ggs.ggScreen();
        }
        if (touch.gameObject.CompareTag("Wall2"))
        {
            Time.timeScale = 0;
            ggs2.ggScreen();
        }
    }

    void AimAtMouse()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        mousePosition.z = 0;

        Vector2 direction = (mousePosition - weaponTransform.position).normalized;

        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;

        weaponTransform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}
