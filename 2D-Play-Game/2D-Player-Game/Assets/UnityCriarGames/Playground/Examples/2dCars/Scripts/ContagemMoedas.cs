using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class ContagemMoedas : MonoBehaviour
{

    [SerializeField] private TMP_Text coinLabel;

    private int coin = 0;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            AudioManager.Instance.PlaySFX("Moeda");
            Debug.Log("Player collected");
            coin += 10;
            Debug.Log("Coin received: " + coin);
            Destroy(other.gameObject);

            coinLabel.text = "Placar: " + coin.ToString();
        }

        if (other.CompareTag("CoinEspecial"))
        {
            AudioManager.Instance.PlaySFX("Moeda");
            Debug.Log("Player collected");
            coin += 20;
            Debug.Log("Coin received: " + coin);
            Destroy(other.gameObject);

            coinLabel.text = "Placar: " + coin.ToString();
        }

         if (other.CompareTag("Portal"))
        {
            Debug.Log("Jogador entro no portal");
        }

}

}




