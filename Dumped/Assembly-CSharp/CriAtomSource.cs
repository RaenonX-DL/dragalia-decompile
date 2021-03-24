/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

[AddComponentMenu]
public class CriAtomSource : MonoBehaviour
{
	// Fields
	[CompilerGenerated]
	private CriAtomExPlayer _player_k__BackingField;
	protected CriAtomEx3dSource source;
	private Vector3 lastPosition;
	private bool hasValidPosition;
	[SerializeField]
	private bool _playOnStart;
	[SerializeField]
	private string _cueName;
	[SerializeField]
	private string _cueSheet;
	[SerializeField]
	private bool _use3dPositioning;
	[SerializeField]
	private bool _loop;
	[SerializeField]
	private float _volume;
	[SerializeField]
	private float _pitch;
	[SerializeField]
	private bool _androidUseLowLatencyVoicePool;
	[SerializeField]
	private bool need_to_player_update_all;

	// Properties
	public CriAtomExPlayer player { [CompilerGenerated] get; [CompilerGenerated] protected set; }
	public bool playOnStart { get; set; }
	public string cueName { get; set; }
	public string cueSheet { get; set; }
	public bool use3dPositioning { get; set; }
	public bool loop { get; set; }
	public float volume { get; set; }
	public float pitch { get; set; }
	public float pan3dAngle { get; set; }
	public float pan3dDistance { get; set; }
	public int startTime { get; set; }
	public long time { get; }
	public Status status { get; }
	public bool attenuationDistanceSetting { get; set; }
	public bool androidUseLowLatencyVoicePool { get; set; }

	// Nested types
	public enum Status
	{
		Stop = 0,
		Prep = 1,
		Playing = 2,
		PlayEnd = 3,
		Error = 4
	}

	[CompilerGenerated]
	private sealed class _PlayAsync_d__72 : IEnumerator<object>
	{
		// Fields
		private int __1__state;
		private object __2__current;
		public CriAtomSource __4__this;
		public string cueName;
		private CriAtomExAcb _acb_5__2;

		// Properties
		object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
		object IEnumerator.Current { [DebuggerHidden] get; }

		// Constructors
		[DebuggerHidden]
		public _PlayAsync_d__72(int __1__state);

		// Methods
		[DebuggerHidden]
		void IDisposable.Dispose();
		private bool MoveNext();
		[DebuggerHidden]
		void IEnumerator.Reset();
	}

	// Constructors
	public CriAtomSource();

	// Methods
	protected void SetNeedToPlayerUpdateAll();
	protected virtual void InternalInitialize();
	protected virtual void InternalFinalize();
	private void Awake();
	private void OnEnable();
	private void OnDestroy();
	protected bool SetInitialSourcePosition();
	protected virtual void SetInitialParameters();
	private void Start();
	private void LateUpdate();
	public void OnDrawGizmos();
	public CriAtomExPlayback Play();
	public CriAtomExPlayback Play(string cueName);
	public CriAtomExPlayback Play(int cueId);
	private void PlayOnStart();
	[IteratorStateMachine]
	private IEnumerator PlayAsync(string cueName);
	public void Stop();
	public void Pause(bool sw);
	public bool IsPaused();
	public void SetBusSendLevel(string busName, float level);
	[Obsolete]
	public void SetBusSendLevel(int busId, float level);
	public void SetBusSendLevelOffset(string busName, float levelOffset);
	[Obsolete]
	public void SetBusSendLevelOffset(int busId, float levelOffset);
	public void SetAisacControl(string controlName, float value);
	[Obsolete]
	public void SetAisac(string controlName, float value);
	public void SetAisacControl(uint controlId, float value);
	[Obsolete]
	public void SetAisac(uint controlId, float value);
	public void AttachToAnalyzer(CriAtomExOutputAnalyzer analyzer);
	public void DetachFromAnalyzer(CriAtomExOutputAnalyzer analyzer);
}

