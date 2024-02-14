using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FinishLevel : MonoBehaviour
{
    [SerializeField] private Text levelText;
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.name == "Player")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
