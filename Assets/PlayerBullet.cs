using UnityEngine;

public class PlayerBullet : MonoBehaviour
{
    public float speed = 7;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.up * speed * Time.deltaTime);
        if (transform.position.y > 10)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }

    }
}

