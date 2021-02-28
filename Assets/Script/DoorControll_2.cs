using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DoorControll_2 : MonoBehaviour , IInteractable
{
    public void Interact()
    {
        transform.DOMoveZ(-21.3f, 0.3f).OnComplete(() => transform.DOMoveX(-2, 0.3f));
    }
}
