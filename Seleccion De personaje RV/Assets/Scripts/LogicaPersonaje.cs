using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPersonaje : MonoBehaviour
{
    public Animator animator;

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Comer()
    {
        animator.SetTrigger("Comer");
    }

    public void Dormir()
    {
        animator.SetTrigger("Dormir");
    }

    public void Bailar()
    {
        animator.SetTrigger("Bailar");
    }

    public void Entrenar()
    {
        animator.SetTrigger("Entrenar");
    }
}
