using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NearstObject : MonoBehaviour
{
    public GameObject closeObject;
    [SerializeField]
    private LayerMask nearstObjectLayer;

    private void Update()
    {
        DeterminationNearstObject();
    }

    //önündeki objeyi bulur bu metotçuk
    private void DeterminationNearstObject()
    {
        Vector3 dir = transform.TransformDirection(Vector3.back);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, dir, out hit, 3, nearstObjectLayer, QueryTriggerInteraction.UseGlobal))
        {
            closeObject = hit.collider.gameObject;
        }
    }

    //Görsel açıdan niceee
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position,transform.position + new Vector3(0,0,-3));
    }
}
