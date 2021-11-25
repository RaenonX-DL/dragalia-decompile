using System;
using UnityEngine;

namespace Gluon
{
	public class LoginBonusEffectAsset : ScriptableObject
	{
		[Serializable]
		public struct SEDefine
		{
			[SerializeField]
			public string seName;

			public float triggerTime;
		}

		[SerializeField]
		public SEDefine[] seList;

		public static LoginBonusEffectAsset GetEffectAsset(string fileName)
		{
			return null;
		}
	}
}
