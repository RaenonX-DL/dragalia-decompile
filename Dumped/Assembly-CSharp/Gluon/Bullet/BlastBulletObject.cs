/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using Gluon.ActionData;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Bullet
{
	public class BlastBulletObject : BulletObject
	{
		// Fields
		private bool _hasFire;
		private float _waitingTime;
		private float _timer;
		private string _waitingEffName;
		private int _waitingEffTrig;
		private ArrangeBulletData.CastingMoveInfo castingMoveInfo;
		private CharacterStates castingStartState;
		private Vector3 startPos;
	
		// Constructors
		public BlastBulletObject();
	
		// Methods
		protected override void Clear();
		public virtual bool Initialize(CharacterBase owner, CommonObjectStatus target, int actionId, int skillId, int productId, Vector3 position, Vector3 scale, Quaternion rotation);
		public void SetCastingMoveInfo(ArrangeBulletData.CastingMoveInfo info);
		protected override void Start();
		private void Fire();
		protected override bool OnUpdate();
		protected override bool UpdateDurationTime();
		public override void OnCollided(GameObject target, bool isPropagation);
		public static string GetHitAttributeLabel(CharacterBase owner, ArrangeBulletData data);
		public void SetupWaitingTime(float time, string waitingEffName, int waitingEffTrig);
		private void Wait();
		private bool IsSyncMoveEnabled();
		[CompilerGenerated]
		private bool _Fire_b__12_0();
	}
}
