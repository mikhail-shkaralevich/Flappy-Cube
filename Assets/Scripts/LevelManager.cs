using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField] private Text levelText;

    void Start()
    {
        levelText.text = "Level: " + (SceneManager.GetActiveScene().buildIndex);
    }
}
