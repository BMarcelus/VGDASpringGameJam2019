using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideCount : MonoBehaviour
{
    public bool collideShape;
    public int collideCount;
    public Manager gameManager;
    public GameObject grid;

    void Awake()
    {
        grid = GameObject.Find("Grid");
        gameManager = grid.GetComponent<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collideShape = true;
        gameManager.AddCollide();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        collideShape = false;
        gameManager.SubtractCollide();
    }
}
