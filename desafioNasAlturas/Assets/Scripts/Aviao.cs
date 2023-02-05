using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aviao : MonoBehaviour
{
    private Rigidbody2D fisica;
    [SerializeField] float forca;

    private void Awake()
    {
        fisica = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Fire1 (botão esquerdo do mouse !
        if (Input.GetButtonDown("Fire1"))
        {
            Impulsionar();
        }
    }

    private void Impulsionar()
    {
        fisica.AddForce(Vector2.up * forca, ForceMode2D.Impulse);
    }
}
