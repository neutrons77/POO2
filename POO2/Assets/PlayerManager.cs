using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public Animator animator;
    private MovimentoPlayer movimentoPlayer;
    public float velocidadeDaAnimacao = 1;

    private Personagem personagem;


    void Start()
    {
        movimentoPlayer = GetComponent<MovimentoPlayer>();
        personagem = GetComponent<Personagem>();
    }

    void Update()
    {
        animator.SetBool("Andando", movimentoPlayer.andando);
        animator.speed = velocidadeDaAnimacao;
    }
}