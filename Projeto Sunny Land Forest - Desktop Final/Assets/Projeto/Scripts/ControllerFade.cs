using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ControllerFade : MonoBehaviour {

	public static ControllerFade _instaciaFade;

	public Image _imagemFade;
	public Color _corInicial;
	public Color _corFinal;
	public float _duracaoFade;

	public bool _isFade;
	private float _tempo;

	void Awake()
    {
		_instaciaFade = this;
    }

	IEnumerator InicioFade()
    {
		_isFade = true;
		_tempo = 0f;

		while( _tempo <= _duracaoFade )
        {
			_imagemFade.color = Color.Lerp(_corInicial, _corFinal, _tempo / _duracaoFade);
			_tempo = _tempo + Time.deltaTime;
			yield return null;
        }

		_isFade = false;

    }

	// Use this for initialization
	void Start () {

		StartCoroutine(InicioFade());
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
