using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeTypeManager : MonoBehaviour
{
    public GameObject[] Shapes;
    public GameObject PlaceEffect;

    public GameObject GetRandomShape() {
      return Shapes[Random.Range(0, Shapes.Length)];
    }
}
