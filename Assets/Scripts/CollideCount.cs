using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideCount : MonoBehaviour
{
    public int collideShape = 0;
    public int collideCount;
    public Manager gameManager;
    private GridEffectsManager effectsManager;
    public GameObject grid;

    private bool targetValue;
    private bool isCorrect;

    void Awake()
    {
        grid = GameObject.Find("Grid");
        gameManager = grid.GetComponent<Manager>();
        effectsManager = grid.GetComponent<GridEffectsManager>();
        targetValue = false;
        isCorrect = true;
        gameManager.AddCollide();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      bool isTarget = collision.tag == "TargetShape";
      if(isTarget) {
        if(!targetValue) gameManager.targetPositives += 1;
        targetValue = true;
      } else {
        collideShape += 1;
        if(targetValue)effectsManager.QueuePositiveEffect(transform);
        else effectsManager.QueueNegativeEffect(transform);
      }
      bool prevIsCorrect = isCorrect;
      isCorrect = (collideShape>0) == targetValue;
      if(prevIsCorrect && !isCorrect) {
        gameManager.SubtractCollide();
        if(!targetValue) gameManager.falsePositives += 1;
      } else if(!prevIsCorrect && isCorrect) {
        gameManager.AddCollide();
        if(targetValue) gameManager.actualPositives += 1;
      }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
      if(collision.tag == "TargetShape") {
        if(targetValue) gameManager.targetPositives -= 1;
        targetValue = false;
      } else {
        collideShape -= 1;
      }
      bool prevIsCorrect = isCorrect;
      isCorrect = (collideShape>0) == targetValue;
      if(prevIsCorrect && !isCorrect) {
        gameManager.SubtractCollide();
        if(targetValue) gameManager.actualPositives -= 1;
      } else if(!prevIsCorrect && isCorrect) {
        gameManager.AddCollide();
        if(!targetValue) gameManager.falsePositives -= 1;
      }
    }
}
