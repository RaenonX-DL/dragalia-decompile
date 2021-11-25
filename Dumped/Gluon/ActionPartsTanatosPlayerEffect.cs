using System.Collections.Generic;
using Gluon.ActionData;
using UnityEngine;

namespace Gluon
{
	public class ActionPartsTanatosPlayerEffect : ActionParts
	{
		private readonly TanatosPlayerEffectData _partsData;

		private Dictionary<EffectObject, CharacterBase> _effectDic;

		public ActionPartsTanatosPlayerEffect(Gluon.ActionData.ActionParts resource)
		{
		}

		protected override void OnStart()
		{
		}

		private EffectObject CreateEffect(CharacterBase owner, CharacterBase target, TanatosPlayerEffectData data)
		{
			return null;
		}

		private bool CalcGeneratePos(TanatosPlayerEffectData data, CharacterBase target, ref Vector3 position, ref Quaternion rotation, ref Vector3 scale, ref Transform attachNode)
		{
			return default(bool);
		}
	}
}
