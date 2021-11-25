using System.Collections.Generic;
using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsSalvationBubble : ActionParts
	{
		private readonly SalvationBubbleData _partsData;

		private CharacterBase _protected;

		private List<CharacterBase> _charactersInArea;

		private CharacterBase _supporter;

		private Vector3 _position;

		private float _range;

		private EffectObject _effObj;

		public ActionPartsSalvationBubble(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnStart()
		{
		}

		public override void Clear()
		{
		}

		protected override void OnFinish()
		{
		}

		protected override bool OnUpdate(float delta)
		{
			return default(bool);
		}

		private void PlaySe(SalvationBubbleData.BubbleState state)
		{
		}
	}
}
