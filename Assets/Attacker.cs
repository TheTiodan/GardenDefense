using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    float moveSpeed = 1f;
    


    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * moveSpeed);
    }

    public void SetMovementSpeed(float speed)
    {
        moveSpeed = speed;
    }
   
}
