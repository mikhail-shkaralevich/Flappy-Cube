using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int coinCount = 0;
    [SerializeField] private Text coinsText;
    [SerializeField] private AudioSource collectCoinSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
            coinCount++;
            coinsText.text = "Coins: " + coinCount;
            collectCoinSound.Play();
        }
    }

    public int GetCoinCount()
    {
        return coinCount;
    }

    public void SetCoinCount(int newCoinCount)
    {
        coinCount = newCoinCount;
    }
}
