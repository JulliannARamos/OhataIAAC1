using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atividade4 : MonoBehaviour
{
    public List<Transform> points;//Os pontos que irá percorrer(waypoints)
    public int pontoAtualIndex = 0;
    public int pontoAlvoIndex = 1;
    public float t = 0;// valor da interpolação entre o ponto atual e o proximo. Famoso lerp
    public bool movimentacaoFinalizada=false;//validei a movimentaçao
    public Material cor;//variavel para mudar de cor
    void Start()
    {
        this.transform.position = points[pontoAtualIndex].position;//Colocando o objeto no primeiro ponto da lista
    }

    // Update is called once per frame
    void Update()
    {
        Movimentacao(); //chamei o metodo
    }
    private void Movimentacao()
    {
        t = t + Time.deltaTime;//tempo que passou da ultima vez que passou o update

        Vector3 newPoint = Vector3.Lerp(points[pontoAtualIndex].position, points[pontoAlvoIndex].position, t);//fazendo a movimentação

        this.transform.position = newPoint; // foi posicionado no novo ponto
        if (t >= 1)//cheguei ao ponto alvo
        {
            points[pontoAlvoIndex].GetComponent<MeshRenderer>().material=cor;//troquei a cor
            t = 0;//reseta o t
            pontoAtualIndex = pontoAlvoIndex;//meu ponto inicial passa a ser o que era o ponto alvo.

            if (pontoAlvoIndex == points.Count - 1)//chequei se meu ponto alvo era o ultimo da lista
            {
                pontoAlvoIndex --;//para voltar no penultimo
                movimentacaoFinalizada = true;
            }
            else if(movimentacaoFinalizada==false)//se não terminei de movimentar, continua movimentando
            {
                pontoAlvoIndex++;//senão for o ultimo, passa a ser o proximo da lista.
            }
        }


    }
}
