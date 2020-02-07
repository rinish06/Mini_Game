using UnityEngine;

public class BatChunkFollower : MonoBehaviour
{
    private BatChunk _batFollower;
	private Rigidbody _rigidbody;
	private Vector3 _velocity;

	[SerializeField]
	private float _sensitivity = 100f;

	private void Awake()
	{
		_rigidbody = GetComponent<Rigidbody>();
	}

	private void FixedUpdate()
	{
		Vector3 destination = _batFollower.transform.position;
		_rigidbody.transform.rotation = transform.rotation;

		_velocity = (destination - _rigidbody.transform.position) * _sensitivity;

		_rigidbody.velocity = _velocity;
		transform.rotation = _batFollower.transform.rotation;
	}

	public void SetFollowTarget(BatChunk batFollower)
	{
		_batFollower = batFollower;
	}
}