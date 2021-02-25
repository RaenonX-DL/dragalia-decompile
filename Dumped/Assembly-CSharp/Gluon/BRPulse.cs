/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BRPulse : MonoBehaviour
	{
		// Fields
		private List<BRPulsePoint> points;
		[CompilerGenerated]
		private Vector3 _areaCirclePos_k__BackingField;
		public float maxRadius;
		[CompilerGenerated]
		private float _areaCircleRadNow_k__BackingField;
		[SerializeField]
		[Tooltip]
		private string actionHitAttributeName;
		[SerializeField]
		[Tooltip]
		private float delaySec;
		[SerializeField]
		[Tooltip]
		private float firstSlowRadius;
		[SerializeField]
		[Tooltip]
		private float firstSlowSec;
		[SerializeField]
		[Tooltip]
		private float firstSlowDamageRatio;
		[SerializeField]
		[Tooltip]
		private float firstSlowDamageIntervalSec;
		[SerializeField]
		[Tooltip]
		private float secondSlowRadius;
		[SerializeField]
		[Tooltip]
		private float secondSlowSec;
		[SerializeField]
		[Tooltip]
		private float secondSlowDamageRatio;
		[SerializeField]
		[Tooltip]
		private float secondSlowDamageIntervalSec;
		[SerializeField]
		[Tooltip]
		private float convergeSecAfterSecondSlow;
		[SerializeField]
		[Tooltip]
		private float lastDamageRatio;
		[SerializeField]
		[Tooltip]
		private float lastDamageIntervalSec;
		private HashSet<CharacterBase> contactCharas;
		private float damageTimer;
		private bool isBeforeStart;
		private float elapsedSec;
		private static readonly string pulseEffectLabel;
		private EffectObject pulseEffectObj;
		private static readonly float pulseEffectScale;
		private bool announced;
		private static readonly float pulseRadiusNotifyEventIntervalTime;
		private float pulseRadiusNotifyEventSendDelayTime;
	
		// Properties
		public Vector3 areaCirclePos { [CompilerGenerated] get; [CompilerGenerated] set; }
		public float areaCircleRadNow { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public HashSet<CharacterBase> ContactCharas { get; }
	
		// Constructors
		public BRPulse();
		static BRPulse();
	
		// Methods
		private void Awake();
		private void OnDestroy();
		private void Start();
		private void Update();
		public void RegisterPoint(BRPulsePoint point);
		private void SetBrAreaData(bool hasAppeared);
		private void SetPulseEffectData(bool hasAppeared);
		public bool IsInside(Vector3 pos, float margin = 0f);
		public void ClearEffect();
		public void SendPulseRadius();
	}
}
