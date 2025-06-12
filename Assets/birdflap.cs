using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D mygidbody2D;
    public float flapStrength;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Camera. = Vector2.right * 20;
        if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            mygidbody2D.linearVelocity = Vector2.up * 10;
        }
    }
}