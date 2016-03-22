using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
    public void Move(Vector3 velocity)
    {
        transform.Translate(velocity);
    }
}
