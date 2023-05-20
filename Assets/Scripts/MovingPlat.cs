using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlat : MonoBehaviour
{
    public float platSpeed;
    public int startPoint;
    public Transform[] points;
    private int i;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = points[startPoint].position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector2.Distance(transform.position, points[i].position) < 0.02f){
            i++;
            if(i == points.Length){
                i=0;
            }
        }
    }
}
