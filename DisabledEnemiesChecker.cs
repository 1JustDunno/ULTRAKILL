using ULTRAKILL.Cheats;
using UnityEngine;
using UnityEngine.Events;

public class DisabledEnemiesChecker : MonoBehaviour
{
	private bool activated;

	public float delay;

	public UnityEvent onDisabledEnemies;

	private void Update()
	{
		if (!activated && (bool)MonoSingleton<StatsManager>.Instance && MonoSingleton<StatsManager>.Instance.levelStarted && DisableEnemySpawns.DisableArenaTriggers)
		{
			activated = true;
			Invoke("Activate", delay);
		}
	}

	private void Activate()
	{
		onDisabledEnemies?.Invoke();
	}
}
