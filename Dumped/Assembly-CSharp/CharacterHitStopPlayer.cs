/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

public class CharacterHitStopPlayer
{
	// Fields
	private State state;
	[CompilerGenerated]
	private float _speedScale_k__BackingField;
	private float counter;
	private float stopTimeLength;
	private float stopDelay;
	private float stopMotionSpeedScale;

	// Properties
	public float speedScale { [CompilerGenerated] get; [CompilerGenerated] set; }

	// Nested types
	private enum State
	{
		None = 0,
		Delay = 1,
		EndWait = 2
	}

	// Constructors
	public CharacterHitStopPlayer();

	// Methods
	public void Clear();
	public bool Start(float length, float delay, float targetSpeedScale);
	private void StartNow(float length, float targetSpeedScale);
	private void StartWithDelay(float length, float delay, float targetSpeedScale);
	public void Update(float delta, float realtimeDelta);
}

