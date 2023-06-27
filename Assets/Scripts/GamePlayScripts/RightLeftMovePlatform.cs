using UnityEngine;

public class RightLeftMovePlatform:MonoBehaviour
{

	[SerializeField] private float speed;

	[SerializeField] private float startingPosition;

	[SerializeField] private float endPosition;

	private bool upMove = true;

	private Vector3 pos;

	void Update()
	{

		transform.localPosition += transform.right * speed * Time.deltaTime;

		if (transform.localPosition.x > endPosition && upMove)
		{

			upMove = false;

			speed*= -1f;
		}

		if (transform.localPosition.x < startingPosition && !upMove)
		{

			upMove = true;

			speed*= -1f;
		}

		pos = transform.localPosition;
	}

	void OnCollisionEnter(Collision col)
	{

		col.gameObject.transform.parent = transform;

	}

	void OnCollisionExit(Collision col)
	{

		col.gameObject.transform.parent = null;

	}

}
