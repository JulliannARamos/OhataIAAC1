using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atvidade : MonoBehaviour
{
    
    public Transform pointStart; 
    public Transform pointFinish;//utilizei o transform para definir a posição
    public float t;//o tempo que vai levar de um lado ao outro
    
    void Start()
    {
        //
    }

    void Update()
    {
        t = t + Time.deltaTime;//tempo que passou da ultima vez que passou o update
        Vector3 newPoint = Vector3.Lerp(pointStart.position, pointFinish.position, t);
        //criei o Vector3 para receber o resultado do metodo, passando o parametro do pointStart, point finish e t
        this.transform.position = newPoint; // foi posicionado no novo ponto

       
    
    }
}
