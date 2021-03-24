/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QuestResultRankingEffect
	{
		// Fields
		private QuestResultFlController clearTimeFlController;
		private QuestResultFlController rankController;
		private int clearTimeNum;
		private int rankingNum;
		private readonly int speriaorRankThreshold;
	
		// Nested types
		public enum RankingEffectType
		{
			ClearTime = 0,
			Rank = 1
		}
	
		// Constructors
		public QuestResultRankingEffect();
	
		// Methods
		public void Init(int questId, FlashPlayerManager fpManager, Transform parent);
		public bool IsInitCompleted(RankingEffectType type);
		public void Enter(RankingEffectType type);
		public void Exit(RankingEffectType type);
	}
}
