using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PaddleMove : MonoBehaviour
{
    
    // Start is called before the first frame update

    [SerializeField] private float _direction;
    [SerializeField] private float _speed;



    public void OnMove(InputValue value)
    {
        _direction = value.Get<float>();
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float newX = transform.position.x + (_direction * _speed * Time.deltaTime);
        transform.position = new Vector3 (newX, 0, 0);
    }
}
