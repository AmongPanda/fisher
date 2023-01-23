using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _speed = 0.05f;
    private bool _dragPoint;
    private bool _dragPointLeft;
    private Vector2 _moveVector;
    private GameObject _player;

    private void Awake() => Application.targetFrameRate = 60;

    private void Start()
    {
        _player = gameObject;
        _dragPoint = false;
        _dragPointLeft = false;
    }

    private void FixedUpdate()
    {
        if (_dragPoint == true) 
            Left();
        
        if (_dragPointLeft == true)
            Right();   
    }

    public void OnUp() => _dragPointLeft = true;
    public void OnDown() => _dragPointLeft = false;
    public void OnUpLeft() => _dragPoint = true;
    public void OnDownLeft() => _dragPoint = false;
    private void Left() => _player.transform.Translate(-0.075f, 0, _speed * Time.deltaTime);
    private void Right() => _player.transform.Translate(0.075f, 0, _speed * Time.deltaTime);

}
