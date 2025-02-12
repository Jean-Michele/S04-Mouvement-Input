using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class bouger : MonoBehaviour
{
    [SerializeField] private float _minX;
    [SerializeField] private float _maxX;
    [SerializeField] private float _minY;
    [SerializeField] private float _maxY;
    
    void Update()
    {
        transform.Translate(Random.Range(_minX, _maxX) * Time.deltaTime, Random.Range(_minY, _maxY) * Time.deltaTime, 0, Space.World);

        if(transform.position.x > 5f)
        {
            Debug.Log(gameObject.name);
        }
    }
}
