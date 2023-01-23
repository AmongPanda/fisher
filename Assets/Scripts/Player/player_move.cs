using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour
{
    

    public float speed = 0.05f;

    public bool Drag_point;
    public bool Drag_point_left;

    private Vector2 moveVector;

    public GameObject player_0;
    void Start()
    {
        Drag_point = false;
        Drag_point_left = false;
        Application.targetFrameRate = 60;
    }

   
    void FixedUpdate()
    {
        if (Drag_point == true) 
        {
            left();
        }
        if (Drag_point_left == true)
        {
            ridhg();
        }
    }
    public void OnUp()
    {
        Drag_point_left = true;
    }
    public void ondown()
    {
        Drag_point_left = false;
    }
    public void OnUp_left()
    {
        Drag_point = true;
    }
    public void ondown_eft()
    {
        Drag_point = false;
    }
    private void left()
    {
        player_0.transform.Translate(-0.075f, 0, speed * Time.deltaTime);
    }
    private void ridhg()
    {
        player_0.transform.Translate(0.075f, 0, speed * Time.deltaTime);
    }

}
