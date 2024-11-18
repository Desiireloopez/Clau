using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/* 
 * Desiré López Diaz
 * 13/11/24
 * 
 * En passar per damunt del objecte LLave:
 *           - Indicar que tenemos llave
 *           - Hacer desaparecer la llave
 *           
 * En passar por encima del objeto Puerta cerrada:
 * 
 * SI tenemos la llave -> Abrir puerta
 * SINO-> Mensaje " Te falta la llave "
 * 
 */

public class DeteccióTriggers : MonoBehaviour
{
    bool TinclaClau = false;
   // public GameObject Clau;//Arrosegar objecte
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("tinc la clau:" + TinclaClau);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Clau")//Mirar si he pasat per la clau
        {
            TinclaClau = true; //indico que tinc la clau
            Debug.Log("tinc la clau:" + TinclaClau);
            Destroy(collision.gameObject);// faig desapareixer la clau
        }
        else if (collision.gameObject.tag == "Porta")//Mirar si he pasat per la porta
        {

            if (TinclaClau)//Tinc la clau == True Comprovar si ja tinc la clau
            {
                Debug.Log("obrir la porta");
                Destroy(collision.gameObject);
                
            }
            else
            {
                Debug.Log("et falta la clau daurada.Porta tancada");
            }

        }
        else 
        {
            Debug.Log("has passat per sobre un element no previst");
        }
    }
}
