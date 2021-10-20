
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{
	[HideInInspector] public Rigidbody2D rb;
	[HideInInspector] public CircleCollider2D col;

	[HideInInspector] public Vector3 pos { get { return transform.position; } }

	public int contador;
	public Text puntos;
	public void OnTriggerEnter2D(Collider2D other)
	{
		contador = contador + 1;
		puntos.text = "Puntos: " + contador;
		
	}
	public void Awake ()
	{
		rb = GetComponent<Rigidbody2D> ();
		col = GetComponent<CircleCollider2D> ();
		contador = 0;
		puntos.text = "Puntos: " + contador;
	}

	public void Push (Vector2 force)
	{
		rb.AddForce (force, ForceMode2D.Impulse);
	}

	public void ActivateRb ()
	{
		rb.isKinematic = false;
	}

	public void DesactivateRb ()
	{
		rb.velocity = Vector3.zero;
		rb.angularVelocity = 0f;
		rb.isKinematic = true;
	}

	// public void RestarEscena()
	// {
	// 	SceneManager.LoadScene("level1");
	// }
}
