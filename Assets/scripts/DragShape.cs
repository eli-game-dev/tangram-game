using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DragShape : MonoBehaviour
{
    private bool canMove;
    private bool dragging;
    Collider2D collider;
    private Vector2 offset;
    
    void Start()
    {
        collider = GetComponent<Collider2D>();
        canMove = false;
        dragging = false;

    }
    
    void OnMouseDown() {

        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
    }
    //this help code help me https://generalistprogrammer.com/game-design-development/unity-drag-and-drop-tutorial/

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if (collider == Physics2D.OverlapPoint(mousePos))
            {
                canMove = true;
            }
            else
            {
                canMove = false;
            }
            if (canMove)
            {
                dragging = true;
            }
           

        }
        if (dragging)
        {
            this.transform.position = mousePos+offset;
            this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y,-2); 
        }
        if (Input.GetMouseButtonUp(0))
        {
            this.transform.position = new Vector3(this.transform.position.x,this.transform.position.y,-1);
            canMove = false;
            dragging = false;
        }
    }
}