using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MouseController : MonoBehaviour
{
    private Mouse mouse;
    // Start is called before the first frame update
    void Start()
    {
        mouse.SetState(new FreeState());

    }

    void OnMouseDrag()
    {
        mouse.SetState(new DragState());
    }

    // Update is called once per frame
    void Update()
    {
        mouse.Update();
        if (Input.GetMouseButtonDown(0))
       {
        
       }
    }
}
