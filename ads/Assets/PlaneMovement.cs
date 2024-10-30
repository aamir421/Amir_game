using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneMovement : MonoBehaviour
{
    public int PlaneSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlaneMove();
    }
    void PlaneMove()
    {
        transform.Translate(Vector3.forward *PlaneSpeed * Time.deltaTime);
    }
}
