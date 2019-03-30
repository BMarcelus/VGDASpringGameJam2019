using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadeAndDestroy : MonoBehaviour
{
    public float time;
    private float totalTime;
    private SpriteRenderer rend;
    // Start is called before the first frame update
    void Start()
    {
        totalTime = time;
        rend = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if(time<=0) {
          Destroy(gameObject);
          return;
        }
        float alpha = time/totalTime;
        Color c = rend.color;
        c.a = alpha;
        rend.color = c;
    }
}
