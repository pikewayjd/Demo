using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ship : MonoBehaviour
{
    public float speed = 4;

    public GameObject bullet;

    public int lifeCount;

    public Image[]lives;
    void Update()
    {
        {
            if (Input.GetKeyUp(KeyCode.Space))
            {
                Instantiate(bullet, transform.position + new Vector3(0, .5f, 0), Quaternion.identity);
            }

            //traveling up
            if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
            {
                transform.Translate(transform.up * speed * Time.deltaTime);
            }

            //traveling down
            if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
            {
                transform.Translate(-transform.up * speed * Time.deltaTime);
            }



            //traveling left
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(-transform.right * speed * Time.deltaTime);
            }

            //traveling right
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(transform.right * speed * Time.deltaTime);
            }

            //setting position to new vector3, storing it as current x position and constraining y position, z is our depth
            transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7f, 7f),
                Mathf.Clamp(transform.position.y, -3.5f, 3.5f), transform.position.z);
        }
    }
    private void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.gameObject.CompareTag("Enemy"))
        {


            lifeCount -= 1;
            if (lifeCount <= 0)
            {
                lifeCount = 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            lives[lifeCount].enabled = false;
        }
    }
}
