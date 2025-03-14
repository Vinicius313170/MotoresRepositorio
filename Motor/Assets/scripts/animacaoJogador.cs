using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacaoJogador : MonoBehaviour
{
    [SerializeField] private Animator animator;

    [SerializeField] private Rigidbody2D rigidbody;

    [SerializeField] private Player player;

    // Update is called once per frame
    void Update()
    {
        if (this.player.noChao)
        {
            float velocidadeX = Mathf.Abs(this.rigidbody.velocity.x);
            if (velocidadeX > 0)
            {
                this.animator.SetBool("Andando", true);

            }
            else
            {
                this.animator.SetBool("Andando", false);
            
            }

        }

    }
}
