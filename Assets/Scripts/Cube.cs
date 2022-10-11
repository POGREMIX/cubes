using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Cube : MonoBehaviour
{
    public Vector3 startPosition = new Vector3(-20, 0, -1);
    private float _velocity;
    private int _maxDistance;
    private float _timeLeft;
    
    void Start()
    {
        transform.position = startPosition;
    }
    
    void Update()
    {
        transform.Translate(new Vector3(_velocity, 0, 0) * Time.deltaTime);
        _timeLeft += Time.deltaTime;
        
        if (transform.position.x > _maxDistance)
        {
            Debug.Log(_timeLeft);
            Destroy(this.gameObject);
        }
    }
    
    public void SetParams(float velocity, int maxDistance)
    {
        _velocity = velocity;
        _maxDistance = maxDistance;
    }
}
