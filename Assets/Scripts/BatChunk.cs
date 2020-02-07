using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatChunk : MonoBehaviour
{
    //[SerializeField]
	public BatChunkFollower _BatChunkFollowerPrefab;

	public void SpawnBatChunkFollower()
	{
		var follower = Instantiate(_BatChunkFollowerPrefab);
		follower.transform.position = transform.position;
		follower.SetFollowTarget(this);
	}

	public void Start()
	{
		SpawnBatChunkFollower();
	}
}
