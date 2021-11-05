using UnityEngine;

public class Ball : MonoBehaviour
{
	[SerializeField]
	private Vector2 startForce;

	public GameObject nextBall;

	[SerializeField]
	private Rigidbody2D rb;

	// Use this for initialization
	void Start()
	{
		rb.AddForce(startForce, ForceMode2D.Impulse);
	}

	public void Split()
	{
		AudioManger.instance.SetEffect(2);

		GameManger.instance.AddPoint();
	
		if (nextBall != null)
		{
			GameObject ball1 = Instantiate(nextBall, rb.position + Vector2.right / 4f, Quaternion.identity);
			GameObject ball2 = Instantiate(nextBall, rb.position + Vector2.left / 4f, Quaternion.identity);

			ball1.GetComponent<Ball>().startForce = new Vector2(2f, 5f);
			ball2.GetComponent<Ball>().startForce = new Vector2(-2f, 5f);
			AudioManger.instance.SetEffect(0);
		}

		Destroy(gameObject);
	}


}
