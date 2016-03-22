using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour
{
    [SerializeField]
    private float lifeTime = 2;

    // Use this for initialization
    void Start()
    {
        Invoke("Destroy", lifeTime);
    }

    void Destroy()
    {
        Destroy(gameObject);
    }
}
