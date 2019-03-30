using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : ScriptableObject
{
  public static GameObject HoverEffect;
  private static GameObject currentlyHeld;
  public static float rotationSpeed = 5f;

  public static void DeselectObject(GameObject obj) {
    DragableObject dragScript = obj.GetComponent<DragableObject>();
    if(!dragScript) {
      Debug.Log("ERROR NO DRAG SCRIPT ON DESELECT", obj);
      return;
    }
    dragScript.StopDragging();
    currentlyHeld = null;
  }

  public static void ObjectClicked(GameObject obj) {
    if(currentlyHeld == obj) {
      DeselectObject(currentlyHeld);
      return;
    }
    if(currentlyHeld != null) {
      DeselectObject(currentlyHeld);
    }
    DragableObject dragScript = obj.GetComponent<DragableObject>();
    if(!dragScript) {
      Debug.Log("ERROR NO DRAG SCRIPT ON SELECT", obj);
      return;
    }
    currentlyHeld = obj;
    dragScript.StartDragging();
  }

}
