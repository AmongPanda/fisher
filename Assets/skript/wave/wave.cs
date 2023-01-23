using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wave : MonoBehaviour
{
   
    private void Update()
    {
        transform.Translate(1, 0, 1 * Time.deltaTime);
    }
}
