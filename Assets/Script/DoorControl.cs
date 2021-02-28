using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoorControl : MonoBehaviour , IInteractable
{
    public void Interact()
    {
        transform.DOLocalMoveY(5, 2);
    }
}
