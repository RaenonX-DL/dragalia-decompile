using System.Runtime.CompilerServices;
using CriMana;
using UnityEngine;

[AddComponentMenu("CRIWARE/CriManaMovieMaterial")]
public class CriManaMovieMaterial : MonoBehaviour
{
	public enum MaxFrameDrop
	{
		Disabled = 0,
		One = 1,
		Two = 2,
		Three = 3,
		Four = 4,
		Five = 5,
		Six = 6,
		Seven = 7,
		Eight = 8,
		Nine = 9,
		Ten = 10,
		Infinite = -1
	}

	public enum RenderMode
	{
		Always,
		OnVisibility,
		Never
	}

	public bool playOnStart;

	public RenderMode renderMode;

	[SerializeField]
	private Material _material;

	[SerializeField]
	private string _moviePath;

	[SerializeField]
	private bool _loop;

	[SerializeField]
	private MaxFrameDrop _maxFrameDrop;

	[SerializeField]
	private bool _additiveMode;

	[SerializeField]
	private bool _advancedAudio;

	[SerializeField]
	private bool _ambisonics;

	[SerializeField]
	private bool _applyTargetAlpha;

	private bool materialOwn;

	private bool isMonoBehaviourStartCalled;

	private GameObject ambisonicSource;

	private bool unpauseOnApplicationUnpause;

	private CriManaMoviePlayerHolder playerHolder;

	public string moviePath
	{
		get
		{
			return null;
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

	public MaxFrameDrop maxFrameDrop
	{
		get
		{
			return default(MaxFrameDrop);
		}
		set
		{
		}
	}

	public bool advancedAudio
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool ambisonics
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool additiveMode
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool applyTargetAlpha
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool isMaterialAvailable
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Player player
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Material material
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected bool HaveRendererOwner
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void Play()
	{
	}

	public void Stop()
	{
	}

	public void Pause(bool sw)
	{
	}

	protected virtual void OnMaterialAvailableChanged()
	{
	}

	protected virtual void OnMaterialUpdated()
	{
	}

	protected virtual void Awake()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected virtual void Start()
	{
	}

	protected virtual void Update()
	{
	}

	public virtual void RenderMovie()
	{
	}

	protected virtual void LateUpdate()
	{
	}

	protected virtual void OnWillRenderObject()
	{
	}

	private void OnApplicationPause(bool appPause)
	{
	}

	private void ProcessApplicationPause(bool appPause)
	{
	}

	protected virtual void OnDrawGizmos()
	{
	}

	private void CreateMaterial()
	{
	}
}
