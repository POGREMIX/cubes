using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Main : MonoBehaviour
{
    public GameObject cubePrefab;
    private Timer _timer;

    private const float Delay = 0;
    public float repeatRate = 3;
    public float velocity = 5;
    public int maxDistance = 100;

    void Start()
    {
        // InvokeRepeating(nameof(InstantiateCube), Delay, repeatRate);
        _timer = GetComponent<Timer>();
        _timer.AddListener(InstantiateCube);
    }

    void InstantiateCube()
    {
        var prefab = Instantiate(cubePrefab);
        var cube = prefab.GetComponent<Cube>();
        cube.SetParams(velocity, maxDistance);
    }
}
