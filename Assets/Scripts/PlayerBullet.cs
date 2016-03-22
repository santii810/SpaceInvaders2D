using UnityEngine;
using System.Collections;

public class PlayerBullet : MonoBehaviour
{
    [SerializeField]
    private float speed = 10;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            collision.gameObject.SetActive(false);
        }
    }
}
