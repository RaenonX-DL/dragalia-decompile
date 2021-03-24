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
	public class PlayerChargeController
	{
		// Fields
		private CharacterBase owner;
		[CompilerGenerated]
		private bool _isCharging_k__BackingField;
		[CompilerGenerated]
		private bool _isExceed_k__BackingField;
		[CompilerGenerated]
		private int _chargeLv_k__BackingField;
		[CompilerGenerated]
		private Vector3? _impactPos_k__BackingField;
		private float afterChargeCompleteSec;
		private const float chargeCompleteWaitSecForAI = 0.1f;
	
		// Properties
		public bool isCharging { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public bool isExceed { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int chargeLv { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool isEnableBurstAttack { get; }
		public Vector3? impactPos { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public PlayerChargeController(CharacterBase owner);
	
		// Methods
		public static float GetChargeCompleteWaitSecForAI(CharacterBase owner);
		public int GetChargeMarkerActionId();
		public void Startup();
		public void Update();
		public void Finish(bool isAttack, bool isGuard = false);
		public void ForceComplete();
		private bool IsAllyTarget();
		private CharacterBase SearchNearestCharacter();
		public bool IsChargeComplete(float waitSec = 0f, int stopChargeLv = 0);
		private void OnChargeComplete();
	}
}
