using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    [SerializeField] float velocidadeDoObstaculo;
    void Update()
    {
        transform.Translate(Vector3.left * velocidadeDoObstaculo);        
    }
}
