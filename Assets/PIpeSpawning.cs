using UnityEngine;

public class PIpeSpawning : MonoBehaviour
{

    public GameObject pipe;
    public float spawnRate =10;
    private float timer = 0;
    public float heightoffset = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnpipe();
    }

    // Update is called once per frame
    void Update()
    {
        //for spawning -->
        if (timer < spawnRate)
        {
            timer +=Time.deltaTime;
        }
        else
        {
            spawnpipe();
            timer = 0;
        }
    }
    void spawnpipe()
    {
        float lowestPoint = transform.position.y + heightoffset;
        float highestPoint = transform.position.y - heightoffset;


        Instantiate(pipe, new Vector3(transform.position.x,Random.Range(lowestPoint, highestPoint),0) ,transform.rotation) ;
    }
}
