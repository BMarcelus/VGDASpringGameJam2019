using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{
    public ShapeTypeManager typeManager;
    private GameObject myShape;
    public GameObject SpawnedShapes;

    void Start() {
      Spawn();
    }
    public void Spawn() {
      GameObject shapeType = typeManager.GetRandomShape();
      myShape = Instantiate(shapeType, transform.position, shapeType.transform.rotation);
      myShape.GetComponent<DragableObject>().mySpawner = this;
      // myShape.transform.parent = SpawnedShapes.transform;
    }
}
