using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class ControleJogador : MonoBehaviour {

    private Animator playerAnimator;
    private Rigidbody2D playerRigidbory2d;
    private SpriteRenderer srPlayer;
    private bool playerInvencivel;

    public GameObject PlayerDie;
    public GameObject GameOver;
    public GameObject GameConfig;

    public Transform groundCheck;
    public bool isGround = false;

    public float speed;

    public float touchRun = 0.0f;

    public bool facingRight = true;

    public int vidas = 3;
    public Color hitcolor;
    public Color noHitcolor;

    // Pulo
    public bool jump = false;
    public int numberJumps = 0;
    public int maximoJump = 2;
    public float jumpForce;

    private ControllerGame _ControleGame;

    public AudioSource fxGame;
    public AudioClip fxPulo;
    public AudioClip fxCenouraColetada;

    public ParticleSystem _poeira;

    // Use this for initialization
    void Start () {

        playerAnimator = GetComponent<Animator>();
        playerRigidbory2d = GetComponent<Rigidbody2D>();
        srPlayer = GetComponent<SpriteRenderer>();

        _ControleGame = FindObjectOfType(typeof(ControllerGame)) as ControllerGame;
		
	}
	
	// Update is called once per frame
	void Update () {

        
        isGround = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Ground"));
        playerAnimator.SetBool("isGrounded", isGround);

        //Debug.Log(isGround.ToString());

        touchRun = Input.GetAxisRaw("Horizontal");
        //Debug.Log(touchRun.ToString());

        if(Input.GetButtonDown("Jump"))  // tecla de espaço
        {
            jump = true;
        }

        SetaMovimentos();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pausa();
        }

    }

    void MovePlayer(float movimentoH)
    {
        playerRigidbory2d.velocity = new Vector2(movimentoH * speed, playerRigidbory2d.velocity.y);

        if(movimentoH < 0 && facingRight || (movimentoH > 0 && !facingRight))
        {
            Flip();
        }


    }

    private void FixedUpdate()
    {
        MovePlayer(touchRun);

        if(jump) // true
        {
            JumpPlayer();
        }
       
    }

    void JumpPlayer()
    {

        if(isGround)
        {
            numberJumps = 0;
            CriarPoeira();
        }

        if(isGround || numberJumps < maximoJump) // true
        {
            playerRigidbory2d.AddForce(new Vector2(0f, jumpForce)); // 600
            isGround = false;
            numberJumps++;

            // Som do pulo
            fxGame.PlayOneShot(fxPulo);

            CriarPoeira();

        }
        jump = false;

    }

    void Flip()
    {
        CriarPoeira();

        facingRight = !facingRight;
        //Vector3 theScale = transform.localScale;
        //theScale.x *= -1;  // 1 ou -1

        transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
    }

    void SetaMovimentos()
    {
        playerAnimator.SetBool("Walk", playerRigidbory2d.velocity.x != 0 && isGround); // true 

        playerAnimator.SetBool("Jump", !isGround);
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Coletaveis":

                _ControleGame.Pontuacao(1);
                fxGame.PlayOneShot(fxCenouraColetada);

                Destroy(collision.gameObject);
                break;

            case "Inimigo":

                // instanciar a animação de explosão
                GameObject tempExplosao = Instantiate(_ControleGame.hitprefab, transform.position, transform.localRotation);
                Destroy(tempExplosao, 0.5f);

                // Adiciona força ao pulo
                Rigidbody2D rb = GetComponentInParent<Rigidbody2D>();
                rb.velocity = new Vector2(rb.velocity.x, 0);
                rb.AddForce(new Vector2(0, 900));

                // Som explosão
                _ControleGame.fxGame.PlayOneShot(_ControleGame.fxExplosao);

                // Destroi inimigo
                Destroy(collision.gameObject);

                break;

            case "Damage":
                Hurt();
                break;


        }

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {

            case "Plataforma":
                this.transform.parent = collision.transform;
                break;

            case "Inimigo":
                Hurt();
                break;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Plataforma":
                this.transform.parent = null;
                break;
        }
    }

    void Hurt()
    {
        if(!playerInvencivel)
        {

            playerInvencivel = true;

            vidas--;  // vidas = vidas - 1
            StartCoroutine("Dano");

            _ControleGame.BarraVida(vidas);

            //Debug.Log("Perdeu uma vida!");

            if(vidas < 1)
            {
                GameObject pDieTemp = Instantiate(PlayerDie, transform.position, Quaternion.identity);
                Rigidbody2D rbDie = pDieTemp.GetComponent<Rigidbody2D>();
                rbDie.AddForce(new Vector2(150f, 500f));

                _ControleGame.fxGame.PlayOneShot(_ControleGame.fxDie);

                Invoke("FimdoJogo", 3f);

                gameObject.SetActive(false);

            }
        }

       
    }

    void CarregaoJogo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    IEnumerator Dano()
    {

        srPlayer.color = noHitcolor;
        yield return new WaitForSeconds(0.1f);

        for(float i =0; i<1; i += 0.1f)
        {
            srPlayer.enabled = false;
            yield return new WaitForSeconds(0.1f);
            srPlayer.enabled = true;
            yield return new WaitForSeconds(0.1f);
        }

        srPlayer.color = Color.white;
        playerInvencivel = false;
    }

    void CriarPoeira()
    {
        _poeira.Play();
    }

    public void Sair()
    {
        Application.Quit();
    }

    public void Voltar()
    {
        if(vidas >=1)
        {
            Time.timeScale = 1;
            GameOver.SetActive(false);
        }
        else
        {
            Invoke("CarregaoJogo", 1f);
            Time.timeScale = 1;
        }
       
    }

    public void FimdoJogo()
    {
        GameOver.SetActive(true);
    }

    public void Pausa()
    {
        GameOver.SetActive(true);
        Time.timeScale = 0;
    }

    public void Configuracao()
    {
        GameConfig.SetActive(true);
        Time.timeScale = 0;
    }

    public void SairConfiguracao()
    {
        GameConfig.SetActive(false);
        Time.timeScale = 1;
    }
}
