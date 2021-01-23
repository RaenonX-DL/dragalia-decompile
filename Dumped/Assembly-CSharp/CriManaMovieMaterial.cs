/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using CriMana;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

[AddComponentMenu]
public class CriManaMovieMaterial : MonoBehaviour
{
	// Fields
	public bool playOnStart;
	[CompilerGenerated]
	private bool _isMaterialAvailable_k__BackingField;
	[CompilerGenerated]
	private Player _player_k__BackingField;
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
	[CompilerGenerated]
	private bool _HaveRendererOwner_k__BackingField;
	private CriManaMoviePlayerHolder playerHolder;

	// Properties
	public string moviePath { get; set; }
	public bool loop { get; set; }
	public MaxFrameDrop maxFrameDrop { get; set; }
	public bool advancedAudio { get; set; }
	public bool ambisonics { get; set; }
	public bool additiveMode { get; set; }
	public bool applyTargetAlpha { get; set; }
	public bool isMaterialAvailable { [CompilerGenerated] get; [CompilerGenerated] private set; }
	public Player player { [CompilerGenerated] get; [CompilerGenerated] private set; }
	public Material material { get; set; }
	protected bool HaveRendererOwner { [CompilerGenerated] get; [CompilerGenerated] private set; }

	// Nested types
	public enum MaxFrameDrop
	{
		Infinite = -1,
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
		Ten = 10
	}

	public enum RenderMode
	{
		Always = 0,
		OnVisibility = 1,
		Never = 2
	}

	// Constructors
	public CriManaMovieMaterial();

	// Methods
	public void Play();
	public void Stop();
	public void Pause(bool sw);
	protected virtual void OnMaterialAvailableChanged();
	protected virtual void OnMaterialUpdated();
	protected virtual void Awake();
	protected virtual void OnEnable();
	protected virtual void OnDisable();
	protected virtual void OnDestroy();
	protected virtual void Start();
	protected virtual void Update();
	public virtual void RenderMovie();
	protected virtual void LateUpdate();
	protected virtual void OnWillRenderObject();
	private void OnApplicationPause(bool appPause);
	private void ProcessApplicationPause(bool appPause);
	protected virtual void OnDrawGizmos();
	private void CreateMaterial();
}

