using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingForward : MonoBehaviour
{
    public float speed = 10f;
    public bool canMove = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (canMove)
        {
            Vector3 cameraForward = Camera.main.transform.forward;
            this.gameObject.transform.Translate(Vector3.forward * Time.deltaTime * speed);
        }
        if(Input.GetButtonDown("fire1"))
        {
            canMove = !canMove;
        }
        
    }

    private void OnCollisionEnter(Collision otherObject)
    {
        if (otherObject.transform.tag == "stopper") 
        {
            canMove = false;
        }
        Debug.Log("colllision detected " + otherObject.gameObject.name);
    }
}
