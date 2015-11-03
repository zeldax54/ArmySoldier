using UnityEngine;

namespace Assets.Scripts.Personaje
{
    public class AnimacionesPlayer : MonoBehaviour
    {

        private Controladorv1 controlador;
        private Animator animator;
        private void Awake()
        {
            controlador = GetComponent<Controladorv1>();
            animator = GetComponent<Animator>();
        }


        private void Update()
        {
            if (controlador.iscorriendo)
            {
                if(controlador.saltando)
                    animator.SetBool("jump", true);
                else
                {
                animator.SetBool("run", true);
                animator.SetBool("idle", false);
                animator.SetBool("walk", false);
                animator.SetBool("jump", false);
                }
               
            }
            else if (controlador.isMovimiento)
            {
                if (controlador.saltando)
                    animator.SetBool("jump", true);
                else
                {
                    if (controlador.caminandoatras)
                    {
                        animator.SetBool("walkback",true);
                        animator.SetBool("idle", false);
                    }
                    else
                    {
                        animator.SetBool("walk", true);
                        animator.SetBool("walkback", false);
                        animator.SetBool("idle", false);
                        animator.SetBool("run", false);
                        animator.SetBool("jump", false);
                    }
                }
            }
            else if (!controlador.isMovimiento)
            {
                if (controlador.saltando)
                    animator.SetBool("jump", true);
                else
                {
                    animator.SetBool("idle", true);
                    animator.SetBool("walk", false);
                    animator.SetBool("walkback", false);
                    animator.SetBool("run", false);
                    animator.SetBool("jump", false);
                }
                
            }
    }
  
    
    }
}
