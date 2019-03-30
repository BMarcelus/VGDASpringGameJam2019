using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeColliders : MonoBehaviour
{
    public GameObject shapeCollider;
    public float prefabSize;
    public int prefabsCount;
    private Vector2 size;
    public Transform LowerRightCorner;
    // Start is called before the first frame update
    void Start()
    {
        size = LowerRightCorner.transform.position - transform.position;
        size.x = Mathf.Abs(size.x);
        size.y = Mathf.Abs(size.y);
        AddPrefab();
        GetPrefabs();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AddPrefab()
    {
      float width = size.x / prefabSize;
      float height = size.y / prefabSize;
        for(int i = 0;i < width; i++)
        {
            for(int j = 0; j < height; j++)
            {
              Vector3 position = transform.position;
              position.x += i * prefabSize + prefabSize/2;
              position.y -= j * prefabSize + prefabSize/2;
                GameObject gameShape = Instantiate(shapeCollider, position, transform.rotation);
                gameShape.transform.localScale *= prefabSize;
                gameShape.transform.parent = transform;
                prefabsCount += 1;
                gameShape.layer = gameObject.layer;
            }
        }
    }

    void GetPrefabs()
    {
        print(transform.childCount);
    }
}
