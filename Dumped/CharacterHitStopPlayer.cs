using System.Runtime.CompilerServices;

public class CharacterHitStopPlayer
{
	private enum State
	{
		None,
		Delay,
		EndWait
	}

	private State state;

	private float counter;

	private float stopTimeLength;

	private float stopDelay;

	private float stopMotionSpeedScale;

	public float speedScale
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public void Clear()
	{
	}

	public bool Start(float length, float delay, float targetSpeedScale)
	{
		return default(bool);
	}

	private void StartNow(float length, float targetSpeedScale)
	{
	}

	private void StartWithDelay(float length, float delay, float targetSpeedScale)
	{
	}

	public void Update(float delta, float realtimeDelta)
	{
	}
}
