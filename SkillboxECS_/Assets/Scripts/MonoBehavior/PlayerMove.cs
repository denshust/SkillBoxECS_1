using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float moveSpeed = 5;
    void Update()
    {
        var position = transform.position;
        Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"), 0);
        position += direction.normalized * moveSpeed / 100;
        transform.position = position;
    }
}
