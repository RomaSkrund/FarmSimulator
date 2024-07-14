using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.EventSystems;
using static UnityEditor.Experimental.GraphView.GraphView;

public class PlayerMovement : MonoBehaviour
{
    private Camera _camera;
    [SerializeField] private LayerMask _layer; 

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MoveSelectedUnits(out Ray ray, out RaycastHit agentTarget);
        }
    }

    private void MoveSelectedUnits(out Ray ray, out RaycastHit agentTarget)
    {
        ray = _camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out agentTarget, 1000f, _layer))
        {   
            gameObject.GetComponent<NavMeshAgent>().SetDestination(agentTarget.point);
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        MoveSelectedUnits(out Ray ray, out RaycastHit agentTarget);
    }
}
