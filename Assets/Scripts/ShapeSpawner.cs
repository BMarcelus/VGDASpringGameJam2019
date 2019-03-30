using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{
    public ShapeTypeManager typeManager;
    private GameObject myShape;

    void Start() {
      Spawn();
    }
    public void Spawn() {
      GameObject shapeType = typeManager.GetRandomShape();
      myShape = Instantiate(shapeType, transform.position, shapeType.transform.rotation);
      myShape.GetComponent<DragableObject>().mySpawner = this;
    }
}
