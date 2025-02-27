using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;


public class NewBehaviourScript : MonoBehaviour
{
 // variables de mouvement et contr�le
    [SerializeField] private float _vitessePromenade;
    
    private Rigidbody _rb;
    private Vector3 directionInput;
    private Animator _animator;
    


    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _animator = GetComponent<Animator>();
    }

    void OnNager(InputValue directionBase)
    {            
        Vector2 directionAvecVitesse = directionBase.Get<Vector2>() * _vitessePromenade;
        directionInput = new Vector3(0f, directionAvecVitesse.x, directionAvecVitesse.y);
    }

    void OnBoost(InputValue bouton)
{
    if (bouton.isPressed)
    {
        directionInput *= 2f;
        _animator.speed *= 2f;
    }
    else
    {
        directionInput /= 2f;
        _animator.speed /= 2f;
    }
}

    void FixedUpdate()
    {
        _rb.velocity = directionInput;

    if (_rb.velocity.z > 0.1f)
    {
        _animator.SetFloat("Speed", 1);
    }
    else if (_rb.velocity.z < -0.1f)
    {
        _animator.SetFloat("Speed", 2);
    }





    else if (_rb.velocity.y > 0.1f)
    {
        _animator.SetFloat("Speed", 3);
    }
    else if (_rb.velocity.y < -0.1f) 
    {
        _animator.SetFloat("Speed", 4);
    }

        else
        {
            _animator.SetFloat("Speed", 0);
        }

}
}
