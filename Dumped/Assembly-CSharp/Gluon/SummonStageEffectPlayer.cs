/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SummonStageEffectPlayer : MonoBehaviour
	{
		// Fields
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
	
		// Nested types
		public enum EffectEvent
		{
			None = 0,
			DropItemTouchGroud = 1
		}
	
		// Constructors
		public SummonStageEffectPlayer();
		static SummonStageEffectPlayer();
	
		// Methods
		private string GenerateEffectName(int effectBaseId, int rawIndex, bool isSE, out int rarity, out int triggerOffset, out EffectEvent e);
		private int GetRarity(int resultIndex);
		private GiftType GetGiftType(int resultIndex);
		private bool GetIsNew(int resultIndex);
		private bool isMulti();
		public void PlayEffect(string playCommand);
		private void PlayEffectBySingleCommand(string playCommand);
		public void WhiteOutEffect(string inOutTimeCommand);
		private int GetTrimmedPositionIndex(int positionIndex);
		public static void DestroyAllPlayingEffects();
		public void OnBoxSummonEvent(int index);
	}
}
