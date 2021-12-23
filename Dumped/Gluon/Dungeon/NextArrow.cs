using System;
using System.Collections;
using Cute.Core;
using UnityEngine;

namespace Gluon.Dungeon
{
	public class NextArrow : FastUpdateMonoBehaviour
	{
		[Flags]
		public enum KickTriggerType
		{
			BLUE_8 = 0x8,
			RED_9 = 0x9,
			GREEN_10 = 0xA,
			YELLOW_11 = 0xB
		}

		public int index;

		public int nextAreaIndex;

		public int targetIndex;

		[SerializeField]
		private bool isNotPlayTriggerEffect;

		[SerializeField]
		[HideInInspector]
		private bool isBossTypeOverride;

		[SerializeField]
		[HideInInspector]
		private bool overrideValue;

		[NonSerialized]
		public bool isNotPlayEffect;

		[NonSerialized]
		public bool isCautionBoss;

		private const string effectName = "EFF_DUN_ETC_001_001";

		private static bool hitFlag;

		[SerializeField]
		private Transform dmodeCollNode;

		public static void SetHitFlagForDmode(bool value)
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void InitializeBossType()
		{
		}

		private IEnumerator Start()
		{
			return null;
		}

		public void PlayEffect(Transform t)
		{
		}

		private IEnumerator CoPlayEffect(Transform targetTrans)
		{
			return null;
		}

		private void OnTriggerStay(Collider other)
		{
		}

		private void OnTriggerEnter(Collider other)
		{
		}

		private void OnTriggerCore(Collider other)
		{
		}
	}
}
