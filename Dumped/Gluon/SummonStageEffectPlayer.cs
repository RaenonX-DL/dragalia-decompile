using System.Collections.Generic;
using UnityEngine;

namespace Gluon
{
	public class SummonStageEffectPlayer : MonoBehaviour
	{
		public enum EffectEvent
		{
			None,
			DropItemTouchGroud
		}

		private const string effectPrefix = "EFF_SMN_";

		private const string sePrefix = "SE_SUMMON_0";

		private const int indexCurrent = 100;

		private const int indexOverallMax = 500;

		private const int indexForceUseResultIndex = 1000;

		private static List<GameObject> playingEffects;

		private const int rSPFXTrigger = 8;

		private const int srSPFXTrigger = 9;

		private const int ssrSPFXTrigger = 10;

		private const int specialTriggerOffset = 3;

		private string GenerateEffectName(int effectBaseId, int rawIndex, bool isSE, out int rarity, out int triggerOffset, out EffectEvent e)
		{
			return null;
		}

		private int GetRarity(int resultIndex)
		{
			return default(int);
		}

		private GiftType GetGiftType(int resultIndex)
		{
			return default(GiftType);
		}

		private bool GetIsNew(int resultIndex)
		{
			return default(bool);
		}

		private bool isMulti()
		{
			return default(bool);
		}

		public void PlayEffect(string playCommand)
		{
		}

		private void PlayEffectBySingleCommand(string playCommand)
		{
		}

		public void WhiteOutEffect(string inOutTimeCommand)
		{
		}

		private int GetTrimmedPositionIndex(int positionIndex)
		{
			return default(int);
		}

		public static void DestroyAllPlayingEffects()
		{
		}

		public void OnBoxSummonEvent(int index)
		{
		}
	}
}
