using Unity.VisualScripting;
using UnityEngine;

public class DraggableObject : MonoBehaviour
{
    
    private void Start(){
        Subject.clean += Implode;
    }

    private void OnDestroy()
    {
        Subject.clean -= Implode;
    }

    private Vector3 screenPoint;
    private Vector3 offset;

     private Vector3 curPosition;
    void OnMouseDown()
    {
       
        screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
        offset = gameObject.transform.position - 
        Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
      
        Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
        curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
        transform.position = curPosition;
    }

    void Update()
    {        
      
    }


    void Implode(){
        Destroy(gameObject);
    }


}
