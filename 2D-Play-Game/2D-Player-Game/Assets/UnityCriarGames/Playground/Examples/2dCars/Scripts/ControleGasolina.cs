using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class ControleGasolina : MonoBehaviour
{
    private float movement;

    public GameObject painelQuit;
    public Image fillImage; // Referência à imagem preenchível

    // Start is called before the first frame update
    void Start()
    {
        // Obtenha a referência à imagem preenchível
        // fillImage = GetComponent<Image>();
    }

    
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("gasolina"))
        {
            Debug.Log("pegou gasosa");
            Destroy(other.gameObject);
            fillImage.fillAmount = 1;

        }
    }
    // Update is called once per frame
    void Update()
    {
        float fillSpeed = 0.2f;

        movement = Input.GetAxis("Horizontal");
        if(movement == 0){
            fillSpeed = 0;
        }

        // // Exemplo: preencha a imagem gradualmente ao longo do tempo
         // Taxa de preenchimento por segundo

        // Verifique se o preenchimento atual é menor que 1 (100%)
        if (fillImage.fillAmount != 0f)
        {
            // Aumente gradualmente o preenchimento
            fillImage.fillAmount -= fillSpeed * Time.deltaTime;
        }
        else
        {
            painelQuit.SetActive(true);
            Time.timeScale = 0;
        }
        
    }

    


}
