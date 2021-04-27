/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AttachEffect : MonoBehaviour
	{
		// Fields
		public string _effectName;
		public Vector3 _offsetPos;
		public Vector3 _offsetRot;
		public Vector3 _scale;
		public EffectObject.FollowRotType _followRotType;
		public EffectObject.FollowScaleType _followScaleType;
		public EffectObject.EraseType _eraseType;
		public float _disappearTime;
		public bool _isRotateOnCharacter;
		public bool effectiveInPerfMode;
		[Header]
		public GameObject modelTransform;
		public int kickTrigger;
		public int matchingSubstituteEffectTrigger;
		public PauseType _pauseType;
		public bool isDisableInGameLowestQuality;
		private EffectObject _effectObject;
		private bool _needsSetup;
		private int _effectLayer;
		private GameObject _goAttachTarget;
		private Transform _characterTransform;
		private bool _isVisible;
		[SerializeField]
		[Tooltip]
		private bool isInGameOnly;
	
		// Properties
		public int effectLayer { get; set; }
	
		// Nested types
		public enum PauseType
		{
			PLAY_SPEED = 0,
			HIDE = 1,
			IGNORE = 2
		}
	
		// Constructors
		public AttachEffect();
	
		// Methods
		public bool IsInGameOnly();
		private void Awake();
		private void OnEnable();
		private void Update();
		private void OnDisable();
		private Quaternion CalcEffectRotate();
		private void SetupEffect();
		private void StopEffect();
		private void UpdateAttachTarget();
		public void SetVisible(bool isVisible);
		public void SetPause(bool isPause);
		public void SetPauseForTimeStop(bool isPause);
		public bool KickTrigger(int trig);
	}
}
