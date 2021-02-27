using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerControl : MonoBehaviour
{
    public NearstObject nearstObjectClass;
    private void Update()
    {
        Move();
        ObjectInteraction();
    }
    void Move()
    {
        transform.Translate(Vector3.back * Time.deltaTime * 5f, Space.World);
    }

    private void ObjectInteraction()
    {
        GameObject myNearstObject = nearstObjectClass.closeObject;
        if (myNearstObject != null)
        {
            var interactable = myNearstObject.GetComponent<IInteractable>();
            interactable?.Interact();
            nearstObjectClass.closeObject = null; // en yakın obje değişkenini sıfırlıyoruz ki dotween uyarı vermesin
        }
    }
}
