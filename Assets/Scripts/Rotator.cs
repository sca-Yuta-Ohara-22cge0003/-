using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //Vector3(15,30,45):��]���ATime.deltaTime:����
        transform.Rotate(new Vector3(15,30,45) * Time.deltaTime);
    }
}
