using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

	public GameObject player; 
	private Vector3 deslocamento;
    // Start is called before the first frame update
    void Start()
    {
		deslocamento=transform.position;
    }

    // Update is called once per frame
    void Update()
    {
		transform.position=player.transform.position+deslocamento;
    }
}
