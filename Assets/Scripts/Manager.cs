using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour
{
    public int collisionCount;
    public float percent;
    private ShapeColliders shapeColliders;
    public Text text;
    public int targetPositives;
    public int actualPositives;
    public int falsePositives;

    // Start is called before the first frame update
    void Start()
    {
        shapeColliders = GetComponent<ShapeColliders>();
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void AddCollide()
    {
        collisionCount += 1;
        percent = 100f * collisionCount / shapeColliders.prefabsCount;
        if(text)
        text.text = "Percent " + percent.ToString("#.00");
    }

    public void SubtractCollide()
    {
        collisionCount -= 1;
        percent = 100f * collisionCount / shapeColliders.prefabsCount;
        if(text)
        text.text = "Percent " + percent.ToString("#.00");
    }

    public float getFilledPercent() {
      return 1f * actualPositives / targetPositives;
    }

    public float getOverflowPercent() {
      return 1f * falsePositives / (shapeColliders.prefabsCount - targetPositives);
    }
}
