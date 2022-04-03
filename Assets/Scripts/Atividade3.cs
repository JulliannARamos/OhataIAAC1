using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atividade3 : MonoBehaviour
{
    public Transform alvo; // objeto que irá seguir
    public float velocidade; // velocidade que irei me mover ate ele
  

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        MovimentacaoObjeto();//chamei o metodo
     
    }
    private void MovimentacaoObjeto()
    {
        Vector3 direcao;//variavel local
        direcao = alvo.position - this.transform.position; //direção deste objeto para o alvo.
        direcao = direcao.normalized;// ira fazer com que a magnitude seja 1
        transform.Translate(direcao * velocidade);//movimenta o objeto na direção do alvo em uma velocidade. 

    }
 
}
