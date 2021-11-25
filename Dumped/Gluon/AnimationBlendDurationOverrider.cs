using System;
using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class AnimationBlendDurationOverrider : MonoBehaviour
	{
		[Serializable]
		private class Data
		{
			[Tooltip("é\u0081·ç§»å\u0089\u008dã\u0081®ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0082\u00afã\u0083ªã\u0083\u0083ã\u0083\u0097å\u0090\u008d")]
			public string fromClipName;

			[Tooltip("é\u0081·ç§»å¾\u008cã\u0081®ã\u0082¹ã\u0083\u0086ã\u0083¼ã\u0083\u0088å\u0090\u008d")]
			public string toStateName;

			[Tooltip("é\u0081·ç§»ã\u0081«ã\u0081\u008bã\u0081\u0091ã\u0082\u008bæ\u0099\u0082é\u0096\u0093ã\u0082\u0092é\u0081·ç§»å\u0089\u008dã\u0083¢ã\u0083¼ã\u0082·ã\u0083§ã\u0083³å°ºã\u0081®å\u0089²å\u0090\u0088ã\u0081§æ\u008c\u0087å®\u009a")]
			public float blendSec;
		}

		[SerializeField]
		[Tooltip("ã\u0083\u0087ã\u0083¼ã\u0082¿é\u0085\u008då\u0088\u0097")]
		private Data[] dataArray;

		[SerializeField]
		[Tooltip("å\u0085\u00a8ã\u0081¦ã\u0081®é\u0081·ç§»æ\u0099\u0082é\u0096\u0093ã\u0082\u0092ä\u00b8\u0080æ\u008b¬æ\u008c\u0087å®\u009aï¼\u00880ä»¥ä\u00b8\u008aã\u0081®å\u0080¤ã\u0081\u00a0ã\u0081\u0091æ\u009c\u0089å\u008a¹ï¼\u0089")]
		private float allBlendSec;

		private Animator animator;

		private Dictionary<string, Data> dataDict;

		private void Start()
		{
		}

		public bool GetBlendDuration(string nextState, out float blendDuration)
		{
			return default(bool);
		}

		private static string GetKeyString(string fromClipName, string toStateName)
		{
			return null;
		}
	}
}
