using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BaseSphere : MonoBehaviour
{
    [SerializeField]
    protected Rigidbody m_rigidBody;
    protected Color m_color;

    protected virtual void Start()
    {
        // ABSTRACTION
        SetAttributes();
        UseForces();
    }

    protected virtual void Update()
    {
        DestroyOutOfBounds();
    }

    protected virtual void SetAttributes()
    {
        SetColor();
        SetBouncyness();
        SetSize();
    }

    protected virtual void UseForces()
    {
        m_rigidBody = GetComponent<Rigidbody>();
        GetRolling();
        GetPushed();
    }

    protected virtual void SetSize()
    {
        gameObject.transform.localScale *= 1f;
    }

    protected virtual void SetBouncyness()
    {
        gameObject.GetComponent<SphereCollider>().material.bounciness = 0.5f;
    }

    protected virtual void SetColor()
    {
        m_color = Color.gray;
        gameObject.GetComponent<Renderer>().material.SetColor("Color", m_color);
    }

    protected virtual void GetRolling()
    {
        m_rigidBody.AddTorque(new Vector3(Random.Range(0.0f, 100.0f), Random.Range(0.0f, 100.0f), Random.Range(0.0f, 100.0f)));
    }

    protected virtual void GetPushed()
    {
        m_rigidBody.AddForce(new Vector3(Random.Range(-100.0f, 100.0f), Random.Range(-100.0f, 100.0f), Random.Range(-100.0f, 100.0f)));
    }

    protected virtual void DestroyOutOfBounds()
    {
        if(gameObject.transform.position.y < -20.0f)
        {
            Destroy(gameObject);
        }
    }
}
