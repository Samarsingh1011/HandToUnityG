using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandTracking : MonoBehaviour
{
    public UDPReceive udpRecieve;
    public GameObject[] handPoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        string data = udpRecieve.data;
        data = data.Remove(0,1);
        data = data.Remove(data.Length - 1,1);
        print(data);
        string[] points = data.Split(',');
        print(points[0]);

        for ( int i = 0; i<21; i++)
        {
            float x = 5-float.Parse(points[i*3])/20;
            float y = float.Parse(points[i*3+1])/20;
            float z = float.Parse(points[i*3+2])/20;
            handPoints[i].transform.localPosition = new Vector3(x,y,z);

        }
    }
}
