using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GestionnairePeripherique : MonoBehaviour
{

    [SerializeField] private Vector3 deplacement;

    private ActionsSousMarinV1 peripheriqueEntree;

    private void Awake() {

        peripheriqueEntree = new ActionsSousMarinV1();

        peripheriqueEntree.Personnage.Nager.performed += LireDeplacement;

    }

    private void LireDeplacement(InputAction.CallbackContext context)
    {
        deplacement = context.ReadValue<Vector3>();
    }

    private void OnEnable() 
    {

        peripheriqueEntree.Personnage.Enable();

    }


    private void OnDisable() {

        peripheriqueEntree.Personnage.Disable();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
