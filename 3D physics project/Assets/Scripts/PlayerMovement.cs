using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Treasure")
        {
            score++;
            GameManager.Instance.Score++
            Destroy(collision.gameObject);
        }

        if (collision.gameObject.tage == "Enemy")
        {
            score--;
            Destroy(gameObject);
        }
    }
}
