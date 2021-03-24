/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.ActionData;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ActionPartsEffect : ActionParts
	{
		// Fields
		private readonly EffectData _partsData;
		private EffectObject _effectObject;
		public Action<EffectObject> onEffectCreatedAction;
		private CharacterBase _firstTargetPlayer;
	
		// Constructors
		public ActionPartsEffect(ActionParts resource);
	
		// Methods
		public override void Initialize(CharacterBase chara);
		protected override void OnStart();
		protected override void OnFinish();
		public override void Clear();
		private EffectObject CreateEffect(CharacterBase owner, EffectData data, out Vector3 effectPos);
		private float GetEffectPlaySpeedScale(EffectData data);
		public override bool Update(float delta);
		public static EffectObject CreateEffectObject(CharacterBase owner, Transform target, EffectData data, int skillId);
		public static EffectObject CreateEffectObject(CharacterBase owner, Transform target, Vector3 targetPosition, Vector3 targetForward, Quaternion targetRotation, Vector3 targetScale, EffectData data, int skillId);
		private bool CalcGeneratePos(EffectData data, CharacterBase owner, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale, ref Transform attachNode);
		public void ForceStop(CharacterBase effectOwner);
	}
}
