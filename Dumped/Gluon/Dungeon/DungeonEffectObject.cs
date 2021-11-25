using System;
using System.Collections;
using SPFX;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class DungeonEffectObject : MonoBehaviour
	{
		public string effectName;

		public int effectTrigger;

		[NonSerialized]
		public EffectObject effectInstanceObject;

		public bool playEffectOnStart;

		[Tooltip("Transformã\u0082\u0092ã\u0083ªã\u0083³ã\u0082\u00afã\u0081\u0095ã\u0081\u009bã\u0082\u008bã\u0083\u008eã\u0083¼ã\u0083\u0089")]
		public GameObject linkedGameObject;

		[Tooltip("å\u0086\u008dç\u0094\u009fé\u0080\u009fåº¦")]
		public float effectSpeed;

		[Tooltip("ä¹\u0097ç®\u0097ã\u0082«ã\u0083©ã\u0083¼")]
		public Color effectColor;

		[Tooltip("ä\u00b8\u008dé\u0080\u008fæ\u0098\u008eåº¦")]
		public float effectOpacity;

		private bool readyPlayEffect;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void PlayEffect()
		{
		}

		private IEnumerator PlayEffectCoroutine()
		{
			return null;
		}

		public SPFXInstance PlayEffectIfReady()
		{
			return null;
		}

		public void StopEffect()
		{
		}

		private SPFXInstance PlayEffectInstance()
		{
			return null;
		}
	}
}
