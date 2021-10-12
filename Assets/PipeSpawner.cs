using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public float maxTime; //Time between each pipe
    public float timer = 1; //Count the time that is passing
    public GameObject pipe;
    public float height;
    // Start is called before the first frame update
    void Start()
    {
        GameObject newpipe = Instantiate(pipe);
        newpipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > maxTime){
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = transform.position + new Vector3(0, Random.Range(height, -height), 0);
            Destroy(newpipe, 15);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
