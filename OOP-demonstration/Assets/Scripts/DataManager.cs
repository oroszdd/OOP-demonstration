using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static DataManager Instance;

    private float m_spawnRateModifier = 60.0f;
    // ENCAPSULATION
    public float spawnRateModifier
    {
        get { return m_spawnRateModifier; }
        set
        {
            if (value < 5.9f || value > 120.1f)
            {
                Debug.Log("Out of permitted range: Balls per minutes");
            }
            else
            {
                m_spawnRateModifier = value;
            }
        }
    }

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
