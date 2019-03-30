using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragableObject : MonoBehaviour
{
    public ShapeSpawner mySpawner;

    private bool beingDragged = false;
    private bool inGrid = false;
    private Collider2D collider2d;
    private Vector3 startPosition;
    // Start is called before the first frame update
    void Start()
    {
        collider2d = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(beingDragged) {
          //
          Vector3 pz = Camera.main.ScreenToWorldPoint(Input.mousePosition);
          pz.z = 0;
          transform.position = pz;

          float rotationInput = -Input.GetAxisRaw("Horizontal") * Time.deltaTime * 100f;
          transform.Rotate(new Vector3(0,0,rotationInput));
        }
    }

    void OnMouseDown() {
      if(!this.enabled)return;
      if(DebugManager.ClickDrag)Debug.Log("Clicked On", gameObject);
      ObjectManager.ObjectClicked(gameObject);
    }

    public void StartDragging() {
      startPosition = transform.position;
      beingDragged = true;
    }

    public void StopDragging() {
      if(DebugManager.ClickDrag)Debug.Log("Stop dragging", gameObject);
      beingDragged = false;
      if(!inGrid) {
        transform.position = startPosition;
      } else {
      if(DebugManager.ClickDrag)Debug.Log("FINAL PLACEMENT", gameObject);
        mySpawner.Spawn();
        collider2d.enabled = false;
        this.enabled = false;
      }
    }

    void OnTriggerEnter2D(Collider2D col) {
      if(DebugManager.Collisions)Debug.Log("TRIGGER ENTER", gameObject);
      if(col.tag == "BuildingGrid") {
        inGrid = true;
        if(beingDragged) {
          ObjectManager.HoverEffect.SetActive(false);
        }
      }
    }

    void OnTriggerExit2D(Collider2D col) {
      if(DebugManager.Collisions)Debug.Log("TRIGGER EXIT", gameObject);
      if(col.tag == "BuildingGrid") {
        inGrid = false;
      }
    }

    void OnMouseOver() {
      if(inGrid)return;
      ObjectManager.HoverEffect.SetActive(true);
      ObjectManager.HoverEffect.transform.position = transform.position;
    }
    void OnMouseExit() {
      if(inGrid)return;
      ObjectManager.HoverEffect.SetActive(false);
    }
}
