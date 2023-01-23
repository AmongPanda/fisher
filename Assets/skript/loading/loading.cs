using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loading : MonoBehaviour
{
    [SerializeField] private float time;

    public GameObject panel_load;
    public GameObject object_timer;
    private void FixedUpdate()
    {
        time += Time.deltaTime;
        if(time >= 5)
        {
            panel_load.SetActive(false);
            Destroy(object_timer);
        }
    }
}
