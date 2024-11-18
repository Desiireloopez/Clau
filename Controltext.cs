using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/* 
 * Desiré López
 * Script para escribir "Hola Clase"
 * Volem posar el text que l'usuari entra per input field en el TEXT de pantalla
 */

public class Controltext : MonoBehaviour
{
    //[SerializeField]
    public Text myText; // Has de asigmar un objecte tipus Legacy TEXT desde Inspector
    public InputField myInputField;

    // Start is called before the first frame update
    void Start()
    {
        myText.text = "Hola Classe!";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OmplirText()
    {
     myText.text = myInputField.text;  //Posem el text que ha emtrat usuari en el text de pantalla
    
    }
}
