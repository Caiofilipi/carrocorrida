using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.AI;

public class uicarro : MonoBehaviour
{
    public carro meuCarro;
    public TMP_Text nomeT;
    public TMP_Text voltaT;
    public TMP_Text posT;
    public TMP_Text velT;
    public GameObject teladevitoria;
    public TMP_Text[] lugar; 

    void Update()
    {
        nomeT.text = "Nome: " + meuCarro.name;
        voltaT.text = "Voltar: " + meuCarro.volta.ToString();
        velT.text = meuCarro.GetComponent<NavMeshAgent>().speed.ToString() + " Km/h";
        posT.text = "Pos: " + meuCarro.pos.ToString();
        GameObject[] carros = GameObject.FindGameObjectsWithTag("carro");
        if (meuCarro.volta == 3)

        {
            Time.timeScale = 0;
            teladevitoria.SetActive(true);
            for (int i= 0; i < lugar.Length; i++)
            {
                lugar[carros[i].GetComponent<carro>().pos -1].text = carros[i].name;
            }
        }
    }

}
