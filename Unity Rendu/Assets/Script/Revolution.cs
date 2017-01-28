using UnityEngine;
using System.Collections;

public class Revolution : MonoBehaviour
{
    public float xaxis = 0;
    public float yaxis = 0;
    public float zaxis = 0;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(xaxis, yaxis, zaxis) * Time.deltaTime);
    }
}
