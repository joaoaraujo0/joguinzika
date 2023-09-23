using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarInputController : MonoBehaviour
{

    [SerializeField]
    private Rigidbody2D carBody;

    [SerializeField]
    private Rigidbody2D frontTireRigiBody;

    [SerializeField]
    private Rigidbody2D backTireRigiBody;

    [SerializeField]
    private float speed;

    [SerializeField]
    private float speedCarBody;
    

    private float movement;
    void Update()
    {
        GetUpdate();
    }

    void FixedUpdate()
    {
       Aceleration();
        
    }

    private void GetUpdate()
    {
        movement = Input.GetAxis("Horizontal");

    }

    private void Aceleration(){
        frontTireRigiBody.AddTorque(-movement * speed * Time.fixedDeltaTime);
        backTireRigiBody.AddTorque(-movement * speed * Time.fixedDeltaTime);
        carBody.AddTorque(-movement * speedCarBody * Time.fixedDeltaTime);
    }

    public void ControleFrente(){
        frontTireRigiBody.AddTorque(-1 * 1000 * Time.fixedDeltaTime);    
        backTireRigiBody.AddTorque(-1 * 1000 * Time.fixedDeltaTime);
        carBody.AddTorque(-1 * 10 * Time.fixedDeltaTime);
    }

      public void ControleAtras(){
        frontTireRigiBody.AddTorque(1 * 1000 * Time.fixedDeltaTime);    
        backTireRigiBody.AddTorque(1 * 1000 * Time.fixedDeltaTime);
        carBody.AddTorque(1 * 10 * Time.fixedDeltaTime);
    }

}
