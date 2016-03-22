using UnityEngine;
using System.Collections;

public class EnemyBullet : MonoBehaviour {
    [SerializeField]
    private float speed = -10;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(gameObject);
            collision.gameObject.SetActive(false);
        }
    }
}
