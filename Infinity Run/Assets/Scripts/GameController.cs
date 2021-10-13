using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{   [Header("Configuração do Chão")]
    public float              _ChaoDestruido;
    public float              _chaoTamanho;
    public GameObject          _chaoPrefab;
    public float               _chaoVelocidade;


    [Header("Configuracao do Obstaculo")]
    public float _ObstaculoTempo;
    public GameObject _ObstaculoPrefab;
    public float _ObstaculoVelocidade;



    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("SpawnObstaculo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnObstaculo() 
    {
        yield return new WaitForSeconds(_ObstaculoTempo);

        GameObject ObjetoObstaculoTemp = Instantiate(_ObstaculoPrefab);
        StartCoroutine("SpawnObstaculo");
    }
}
