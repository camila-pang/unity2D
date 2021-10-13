using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveOffSet : MonoBehaviour
{
    [Header("Materials")]
    private Renderer    objetoRender;
    private Material    objetoMaterial;
    public float        offset;
    public float        offsetIncrementado;
    public float        offsetVelocidade;

    [Header("Organização das Camadas")]
    // Ordem das Camadas
    public string       sortingLayer;
    public int          orderInLayer;


    // Start is called before the first frame update
    void Start()
    {

        // Pega as propriedades do Mesh Renderer
        objetoRender = GetComponent<MeshRenderer>();

        // Alterar Layer
        objetoRender.sortingLayerName = sortingLayer;
        objetoRender.sortingOrder = orderInLayer;

        // Aplica o Material
        objetoMaterial = objetoRender.material;
    }

    // Update is called once per frame
    void Update()
    {

        // Realiza o movimento
        offset += offsetIncrementado;
        objetoMaterial.SetTextureOffset("_MainTex", new Vector2(offset * offsetVelocidade, 0));
    }
}
