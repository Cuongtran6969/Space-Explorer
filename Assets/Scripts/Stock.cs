using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stock : MonoBehaviour
{

    public float moveSpeed;
    float xDirection;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        xDirection = Input.GetAxisRaw("Horizontal");
        float moveStep = moveSpeed * Time.deltaTime * xDirection;
        if ((transform.position.x <= -9.78 && xDirection < 0) || (transform.position.x >= 9.89 && xDirection > 0))
        {
            return;
        }
        transform.position = transform.position + new Vector3(moveStep, 0, 0);
    }
}
