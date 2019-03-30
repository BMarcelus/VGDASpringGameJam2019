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
    private bool startDrag;
    private float scale = 1.2f;
    private bool placed = false;
    AudioManager audioManager;
    // Start is called before the first frame update
    void Start()
    {
        collider2d = GetComponent<Collider2D>();
        gameObject.layer = 9;
        startDrag = false;
        transform.localScale /= (1+scale)/2;
        // transform.localScale *= 0.5f;
        audioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
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
            if(rotationInput != 0) {
                audioManager.PlaySound("RotationSound");
            }
            else {
                audioManager.StopSound("RotationSound");
            }
            if (Input.GetMouseButtonDown(0)&&!startDrag) {
            OnMouseDown();
          }
          startDrag = false;
          if(inGrid) {
            ObjectManager.HoverEffect.transform.position = transform.position;
          }
        }
    }

    void OnMouseDown() {
      if(!this.enabled)return;
      if(DebugManager.ClickDrag)Debug.Log("Clicked On", gameObject);
      ObjectManager.ObjectClicked(gameObject);
        audioManager.PlaySound("ItemPlaced");
    }

    public void StartDragging() {
      startPosition = transform.position;
      beingDragged = true;
      startDrag = true;
      ObjectManager.HoverEffect.SetActive(false);
      // transform.localScale *= 2;

    }

    public void StopDragging() {
      if(DebugManager.ClickDrag)Debug.Log("Stop dragging", gameObject);
      beingDragged = false;
      if(!inGrid) {
        transform.position = startPosition;
        ObjectManager.HoverEffect.SetActive(false);
        // transform.localScale *= 0.5f;
      } else {
        if(DebugManager.ClickDrag)Debug.Log("FINAL PLACEMENT", gameObject);
        mySpawner.Spawn();
        // collider2d.enabled = false;
        gameObject.layer = 0;
        GameObject effect = Instantiate(mySpawner.typeManager.PlaceEffect, transform.position, Quaternion.identity);
        Destroy(effect,2);
        transform.position += Vector3.forward*2;
        transform.parent = mySpawner.typeManager.SpawnedShapes.transform;
        ObjectManager.HoverEffect.SetActive(false);
        placed = true;
        this.enabled = false;
      }
    }

    void OnTriggerEnter2D(Collider2D col) {
      if(DebugManager.Collisions)Debug.Log("TRIGGER ENTER", gameObject);
      if(col.tag == "BuildingGrid") {
        inGrid = true;
        transform.localScale*=scale;
      }
    }

    void OnTriggerExit2D(Collider2D col) {
      if(DebugManager.Collisions)Debug.Log("TRIGGER EXIT", gameObject);
      if(col.tag == "BuildingGrid") {
        inGrid = false;
        transform.localScale/=scale;
        ObjectManager.HoverEffect.SetActive(false);
      }
    }

    void OnMouseOver() {
      if(placed)return;
      if(beingDragged&&!inGrid)return;
      ObjectManager.HoverEffect.SetActive(true);
      ObjectManager.HoverEffect.transform.position = transform.position;
    }
    void OnMouseExit() {
      if(inGrid)return;
      ObjectManager.HoverEffect.SetActive(false);
    }
}
