using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed;

    private void Start()
    {
        Destroy(gameObject,7);
    }
    void FixedUpdate()
    {
        transform.position += Vector3.left*Speed*Time.deltaTime;
    }
}
