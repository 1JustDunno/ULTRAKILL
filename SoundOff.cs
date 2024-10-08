using UnityEngine;

public class SoundOff : MonoBehaviour
{
	private AudioSource aud;

	private void Start()
	{
		aud = GetComponentInChildren<AudioSource>();
	}

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.CompareTag("Player"))
		{
			aud.volume = 0f;
		}
	}
}
