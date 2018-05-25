using System.Collections;
using UnityEngine;

public class SpawnerPipe : MonoBehaviour {
    [SerializeField]
    private GameObject pipeHolder;
  
	// Use this for initialization
	void Awake () {
        StartCoroutine(Spawner());
        Debug.Log("Starcountine");
	}
	
	// render pipe
	IEnumerator Spawner()
    {
        yield return new WaitForSeconds(1.2f);
        Vector3 temp = transform.position;
        temp.y = Random.Range(-2.5f, 2.5f);
        Instantiate(pipeHolder,temp,Quaternion.identity);
        StartCoroutine(Spawner());
    }
}
