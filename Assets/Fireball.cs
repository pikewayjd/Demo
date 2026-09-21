using Unity.VisualScripting;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public int speed = 4;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.right * speed * Time.deltaTime);
    }
}
