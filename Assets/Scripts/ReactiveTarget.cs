using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReactiveTarget : MonoBehaviour
{
    private bool alreadyDead = false;
    public void ReactToHit() {
        WanderingAI behavior = GetComponent<WanderingAI>();
        if (behavior != null) {
            behavior.SetAlive(false);
        }

        StartCoroutine(Die());        
        
    }
    
    private IEnumerator Die() {
        if (alreadyDead != true) {
            this.transform.Rotate(-90, 0, 0);
            this.transform.Translate(0, 0, -0.5f);
        }
        alreadyDead = true;

        yield return new WaitForSeconds(1.5f);

        Destroy(this.gameObject);
        alreadyDead = false;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
