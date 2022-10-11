using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Timer : MonoBehaviour
{
    public UnityEvent timeoutEventHandler;
    private Main _main;
    private float _repeatRate;
    
    void Start()
    {
        _main = transform.gameObject.GetComponent<Main>();
        _repeatRate = _main.repeatRate;
    }
    
    void Update()
    {
        if (_repeatRate > 0)
        {
            _repeatRate -= Time.deltaTime;
        }
        else
        {
            timeoutEventHandler.Invoke();
            ResetTimer();
        }
    }

    void ResetTimer()
    {
        _repeatRate = _main.repeatRate;
    }

    public void AddListener(UnityAction action)
    {
        timeoutEventHandler.AddListener(action);
    }
}
