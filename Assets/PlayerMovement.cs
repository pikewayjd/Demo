using TMPro;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public TextMeshProUGUI scoreBox;
    public float speed = 4;
    private int scoreVal = 0;

    private void Start()
    {
        scoreBox.text = "Score: " + scoreVal;
    }
    // Update is called once per frame
    void Update()
    {
        //traveling up
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(transform.up * speed * Time.deltaTime);
        }

        //traveling down
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(-transform.up * speed * Time.deltaTime);
        }

        transform.position = new Vector3(transform.position.x, Mathf.Clamp(transform.position.y, -4f, 3.4f), transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Projectile")
        {
            if (collision.gameObject.GetComponent<Projectile>() != null)
            {
                scoreVal += collision.gameObject.GetComponent<Projectile>().points;
                scoreBox.text = "Score: " + scoreVal;
            }
        }
        Destroy(collision.gameObject);
    }
}
