using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridEffectsManager : MonoBehaviour
{
    Queue<Transform> positiveQueue = new Queue<Transform>();
    // List<Transform> positiveQueue = new List<Transform>();
    Queue<Transform> negativeQueue = new Queue<Transform>();
    public float offsetTime;
    private float time;
    public GameObject positiveEffect;
    public GameObject negativeEffect;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(time>0) {
          time -= Time.deltaTime;
        } else {
          time = offsetTime;
          if(positiveQueue.Count > 0) {
            Transform t = positiveQueue.Peek();
            GameObject e = Instantiate(positiveEffect, t.position, Quaternion.identity);
            e.transform.localScale = t.localScale;
            positiveQueue.Dequeue();
          }
          if(negativeQueue.Count > 0) {
            Transform t = negativeQueue.Peek();
            GameObject e = Instantiate(negativeEffect, t.position, Quaternion.identity);
            e.transform.localScale = t.localScale;
            negativeQueue.Dequeue();
          }
        }
    }

    public void QueuePositiveEffect(Transform t) {
      positiveQueue.Enqueue(t);
    }
    public void QueueNegativeEffect(Transform t) {
      negativeQueue.Enqueue(t);
    }
}
