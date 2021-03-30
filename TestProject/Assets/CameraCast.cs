using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCast : MonoBehaviour
{
    Camera cam;
    [SerializeField] LayerMask layerMask;
    PlayerController p;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
        p = FindObjectOfType<PlayerController>();
    }

    public void SendRay()
    {
        RaycastHit hit;
        Ray r = cam.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(r, out hit, 100.0f, layerMask))
        {
            Debug.Log(hit.collider.gameObject.name);
            // Send location info to player
            p.MoveTo(hit.point);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) SendRay();
    }
}
