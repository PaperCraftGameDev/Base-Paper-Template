using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wander : MonoBehaviour
{

    private Vector3 initialPosition;
    public float speed = 1;
    public float maxDistance = 3;

    public bool active = true;

    private Vector3 endLocation;


    // Use this for initialization
    void Start()
    {
        initialPosition = transform.position;
        endLocation = initialPosition;
        StartCoroutine(MoveAround());
    }

    // Update is called once per frame
    void Update()
    {
    }

    private IEnumerator MoveAround()
    {
        while(active)
        {
            if (transform.position == endLocation)
            {
                //Choose end location
                float newx = Random.Range(-maxDistance, maxDistance);
                float newz = Random.Range(-maxDistance, maxDistance);
                endLocation = new Vector3(initialPosition.x + newx, initialPosition.y, initialPosition.z + newz);
                yield return new WaitForSeconds(Random.Range(2.0f,4.0f));
            }
            else
            {
                //apply movement
                float step = speed * Time.deltaTime;
                transform.position = Vector3.MoveTowards(transform.position, endLocation, step);
            }
            yield return null;
        }
        yield return null;
    }
}
