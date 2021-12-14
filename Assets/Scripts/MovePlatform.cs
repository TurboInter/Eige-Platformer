using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    [SerializeField] private float speed = 0;

    private int direction = 0;
    
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        switch (direction)
        {
            case 0:
                Vector3 distance = Vector3.right * speed;
                transform.position += distance;
                break;
            case 1:
                distance = Vector3.left * speed;
                transform.position += distance;
                break;
                
        }

        if (transform.position.x > 30 || transform.position.x < 22)
        {
            changeDirection();
        }
        
    }
    
    void changeDirection()
    {
        if (direction == 0)
        {
            direction = 1;
            return;
        }
        direction = 0;
    }
    
    
}
