using UnityEngine;
using System.Collections;

public class Footsteps_VFX : MonoBehaviour {

	public GameObject leftFootprintPrefab;
	public GameObject rightFootprintPrefab;
	
	public GameObject leftDirtPrefab;
	public GameObject rightDirtPrefab;
	
	public Transform leftFootPosition;
	public Transform rightFootPosition;


	void LeftFootSplash ()
	{

		Instantiate(leftFootprintPrefab, leftFootPosition.position, leftFootPosition.rotation);
		Instantiate(leftDirtPrefab, leftFootPosition.position, leftFootPosition.rotation);

	}

	void OnFootStep()
	{
	}


	void RightFootSplash ()
	{
		Instantiate(rightFootprintPrefab, rightFootPosition.position, rightFootPosition.rotation);
		Instantiate(rightDirtPrefab, leftFootPosition.position, leftFootPosition.rotation);

	}

}


