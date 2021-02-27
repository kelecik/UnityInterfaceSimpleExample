using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoorControl : MonoBehaviour , IInteractable
{
    void DoorMove()
    {
        transform.DOLocalMoveY(5, 2);
        Debug.Log("bura girdi");
    }

    public void Interact()
    {
        DoorMove();
    }
}
