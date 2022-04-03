using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atividade3Alvo : MonoBehaviour
{
    public List<Transform> points;//Os pontos que irá percorrer (waypoints)
    public int pontoAtualIndex=0;
    public int pontoAlvoIndex=1;
    public float t = 0;// valor da interpolação entre o ponto atual e o proximo. Famoso lerp
    void Start()
    {
        this.transform.position = points[pontoAtualIndex].position;//Colocando o objeto no primeiro ponto da lista
    }

    // Update is called once per frame
    void Update()
    {
        MovimentacaoAlvo(); //chamei o metodo
    }
    private void MovimentacaoAlvo()
    {
        t = t + Time.deltaTime;//tempo que passou da ultima vez que passou o update

        Vector3 newPoint = Vector3.Lerp(points[pontoAtualIndex].position, points[pontoAlvoIndex].position, t);//fazendo a movimentação

        this.transform.position = newPoint; // foi posicionado no novo ponto
        if (t >= 1)//cheguei ao ponto alvo
        {
            t = 0;//reseta o t
            pontoAtualIndex = pontoAlvoIndex;//meu ponto inicial passa a ser o que era o ponto alvo.
           
            if (pontoAlvoIndex == points.Count - 1)//chequei se meu ponto alvo era o ultimo da lista
            {
                pontoAlvoIndex = 0;//se ele for o ultimo ponto da lista, ele passa a ser o primeiro
            }
            else
            {
                pontoAlvoIndex++;//senão for o ultimo, passa a ser o proximo da lista.
            }
        }


    }
}
