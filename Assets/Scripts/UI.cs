using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    private string _repeatRate;
    private string _velocity;
    private string _maxDistance;
    
    public void ChangeCubeParams()
    {
        List<Transform> children = new();
        foreach (Transform child in transform)
        {
            children.Add(child);
        }

        //TODO: поискать более быстрый и простой способ
        var _repeatRate = children[0].gameObject.GetComponent<TMP_InputField>().text;
        var _velocity = children[1].gameObject.GetComponent<TMP_InputField>().text;
        var _maxDistance = children[2].gameObject.GetComponent<TMP_InputField>().text;

        var mainObject = GameObject.Find("Main");
        var main = mainObject.GetComponent<Main>();
        
        //TODO: добавить обработку исключений
        main.repeatRate = float.Parse(_repeatRate);
        main.velocity = float.Parse(_velocity);
        main.maxDistance = int.Parse(_maxDistance);
    }
}
