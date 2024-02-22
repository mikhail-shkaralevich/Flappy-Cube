using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishLevel : MonoBehaviour
{

    [SerializeField] private GameObject levelManager;

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Player")
        {
            levelManager.GetComponent<LevelManager>().finishLevel();
        }
    }
}
