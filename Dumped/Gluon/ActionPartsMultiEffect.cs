using System.Collections.Generic;
using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsMultiEffect : ActionPartsEffect
	{
		private readonly MultiEffectData _partsData;

		private List<EffectObject> effecObjects;

		private float _delayTime;

		private int _generateCnt;

		private Vector3 _originPos;

		private float _forwardRot;

		public ActionPartsMultiEffect(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnFinish()
		{
		}

		public override void Clear()
		{
		}

		protected override void OnStart()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		private bool CreateEffect()
		{
			return default(bool);
		}
	}
}
