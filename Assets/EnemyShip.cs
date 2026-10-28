using UnityEngine;

public class EnemyShip : MonoBehaviour
{
    public float speed = 3;

    public GameObject bullet;

    public GameObject explosion;

    public float bulletTimer = 0, bulletWait = 3;


    // Update is called once per frame
    void Update()
    {
        bulletTimer += Time.deltaTime;
        transform.Translate(-transform.up * speed * Time.deltaTime);

        if (bulletTimer > bulletWait)
        {
            bulletTimer = 0;
            Instantiate(bullet, transform.position, Quaternion.identity);


            if (transform.position.y < -10)
            {
                Destroy(gameObject);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("GalagaPlayer"))
        {
            
            GameObject temp = Instantiate(explosion, transform.position, Quaternion.identity);
            Destroy(temp, 1.0f);
            Destroy(gameObject);
        }
        
    }
}
