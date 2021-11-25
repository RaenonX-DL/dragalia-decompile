using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

[AddComponentMenu("CRIWARE/CRI Atom Source")]
public class CriAtomSource : MonoBehaviour
{
	public enum Status
	{
		Stop,
		Prep,
		Playing,
		PlayEnd,
		Error
	}

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

	public CriAtomExPlayer player
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public bool playOnStart
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public string cueName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string cueSheet
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool use3dPositioning
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool loop
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public float volume
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float pitch
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float pan3dAngle
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float pan3dDistance
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public int startTime
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public long time => default(long);

	public Status status => default(Status);

	public bool attenuationDistanceSetting
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool androidUseLowLatencyVoicePool
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	protected void SetNeedToPlayerUpdateAll()
	{
	}

	protected virtual void InternalInitialize()
	{
	}

	protected virtual void InternalFinalize()
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	protected bool SetInitialSourcePosition()
	{
		return default(bool);
	}

	protected virtual void SetInitialParameters()
	{
	}

	private void Start()
	{
	}

	private void LateUpdate()
	{
	}

	public void OnDrawGizmos()
	{
	}

	public CriAtomExPlayback Play()
	{
		return default(CriAtomExPlayback);
	}

	public CriAtomExPlayback Play(string cueName)
	{
		return default(CriAtomExPlayback);
	}

	public CriAtomExPlayback Play(int cueId)
	{
		return default(CriAtomExPlayback);
	}

	private void PlayOnStart()
	{
	}

	private IEnumerator PlayAsync(string cueName)
	{
		return null;
	}

	public void Stop()
	{
	}

	public void Pause(bool sw)
	{
	}

	public bool IsPaused()
	{
		return default(bool);
	}

	public void SetBusSendLevel(string busName, float level)
	{
	}

	[Obsolete]
	public void SetBusSendLevel(int busId, float level)
	{
	}

	public void SetBusSendLevelOffset(string busName, float levelOffset)
	{
	}

	[Obsolete]
	public void SetBusSendLevelOffset(int busId, float levelOffset)
	{
	}

	public void SetAisacControl(string controlName, float value)
	{
	}

	[Obsolete]
	public void SetAisac(string controlName, float value)
	{
	}

	public void SetAisacControl(uint controlId, float value)
	{
	}

	[Obsolete]
	public void SetAisac(uint controlId, float value)
	{
	}

	public void AttachToAnalyzer(CriAtomExOutputAnalyzer analyzer)
	{
	}

	public void DetachFromAnalyzer(CriAtomExOutputAnalyzer analyzer)
	{
	}
}
