using System;
using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsEffect : ActionParts
	{
		private struct StartActionParam
		{
			public CommonObjectStatus target;

			public Vector3 initialPosition;

			public Vector3 initialDirection;

			public void Clear()
			{
			}
		}

		private readonly Gluon.ActionData.EffectData _partsData;

		private EffectObject _effectObject;

		public Action<EffectObject> onEffectCreatedAction;

		private CharacterBase _firstTargetPlayer;

		private AnimatableObject _animatableObject;

		private StartActionParam _startActionParam;

		public ActionPartsEffect(Gluon.ActionData.ActionParts resource)
		{
		}

		public override void Initialize(CharacterBase chara)
		{
		}

		protected override void OnStart()
		{
		}

		protected override void OnFinish()
		{
		}

		public override void Clear()
		{
		}

		private EffectObject CreateEffect(CharacterBase owner, Gluon.ActionData.EffectData data, out Vector3 effectPos)
		{
			return null;
		}

		private float GetEffectPlaySpeedScale(Gluon.ActionData.EffectData data)
		{
			return default(float);
		}

		public override bool Update(float delta)
		{
			return default(bool);
		}

		public static EffectObject CreateEffectObject(CharacterBase owner, Transform target, Gluon.ActionData.EffectData data, int skillId)
		{
			return null;
		}

		public static EffectObject CreateEffectObject(CharacterBase owner, Transform target, Vector3 targetPosition, Vector3 targetForward, Quaternion targetRotation, Vector3 targetScale, Gluon.ActionData.EffectData data, int skillId)
		{
			return null;
		}

		private bool CalcGeneratePos(Gluon.ActionData.EffectData data, CharacterBase owner, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale, ref Transform attachNode)
		{
			return default(bool);
		}

		public void ForceStop(CharacterBase effectOwner, bool isAnimatableObjectOnly = false)
		{
		}

		private CharacterBase GetOwnerToStartActionCharacter()
		{
			return null;
		}
	}
}
