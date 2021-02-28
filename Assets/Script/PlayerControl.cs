using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerControl : MonoBehaviour
{
    private void Start()
    {
        transform.DOMoveZ(-29, 10);
    }

    private void ObjectInteraction(GameObject nearObject)
    {  
            var interactable = nearObject.GetComponent<IInteractable>();
            interactable?.Interact();      
    }


    private void OnTriggerEnter(Collider other)
    {
        ObjectInteraction(other.gameObject);
    }
}
