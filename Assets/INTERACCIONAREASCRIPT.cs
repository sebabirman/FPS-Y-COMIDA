using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;

public class INTERACCIONAREASCRIPT : MonoBehaviour
{
    int puntaje;
    public Text txtpuntaje;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        PickUpScript pickup;
        pickup = other.GetComponent<PickUpScript>();
        puntaje += pickup.puntosItem;
        txtpuntaje.text = "Puntaje" + puntaje;

        if(pickup.esComida == true)
        {
            Destroy(other.gameObject);
        }
    }
}
