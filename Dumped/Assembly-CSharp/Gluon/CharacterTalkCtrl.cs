/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterTalkCtrl
	{
		// Fields
		private CharaTalkElement srcElement;
		private CharaTalkElement dstElement;
		private int srcIdx;
		private float noInputSec;
		private PlayerCtrl prevPlayer;
		private Dictionary<HumanCharacter, int> playedIntervalDic;
		private Dictionary<CharacterBase, List<TalkData>> talkDict;
		private List<TalkData> delayTalks;
		private List<EnemyCharacter> rareEnemies;
		private HashSet<int> registeredRareEnemyGenerateIds;
		private const float DETECT_RARE_ENEMY_LENGTH = 6f;
		private List<EnemyCharacter> powerfulEnemies;
		private HashSet<int> registeredPowerfulEnemyGenerateIds;
		private const float DETECT_POWERFUL_ENEMY_LENGTH = 10f;
		private Dictionary<int, Material> _materialDict;
		private float intervalTimer;
	
		// Nested types
		public enum TalkType
		{
			None = 0,
			CrossTalk = 1,
			Soliloquy = 2
		}
	
		public enum Situation
		{
			None = 0,
			QuestStart = 1,
			QuestStartReply = 2,
			Recovery = 3,
			RecoveryReply = 4,
			BossBattle = 5,
			BossBattleReply = 6,
			SoliloquyStart = 7,
			HPWarning = 7,
			OpenTreasureBox = 8,
			BossPinch = 9,
			BossBreak = 10,
			RareEnemy = 11,
			Dead = 12,
			DefeatBySkill = 13,
			DPMax = 14,
			Interval = 15
		}
	
		private class TalkData
		{
			// Fields
			public CharacterBase src;
			public CharacterBase dst;
			public TalkType type;
			public Situation situation;
			public float delaySec;
	
			// Constructors
			public TalkData(CharacterBase src, CharacterBase dst, TalkType type, Situation situation, float delaySec);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass33_0
		{
			// Fields
			public int charaId;
			public TalkType type;
			public Situation situation;
	
			// Constructors
			public __c__DisplayClass33_0();
	
			// Methods
			internal bool _GetCharaTalkElement_b__0(CharaTalkElement i);
			internal bool _GetCharaTalkElement_b__1(CharaTalkElement i);
		}
	
		// Constructors
		public CharacterTalkCtrl();
	
		// Methods
		public void Initialize();
		public void Update();
		public void ClearRegisteredTalk();
		public int GetRegisteredTalkCount();
		public void SetDPMaxAction();
		public void AddEnemyDeadEvent();
		private void EnemyDeadEvent(EnemyCharacter deadEnemy);
		public void Register(CharacterBase srcChara, CharacterBase dstChara, TalkType type, Situation situation, float delaySec = 0f);
		public void RegisterRandom(Situation situation, List<CharacterBase> exceptCharas = null);
		private bool PlayInterval();
		private void AddTalk(CharacterBase srcChara, TalkData talk);
		private bool Play(CharacterBase srcChara, CharacterBase dstChara, TalkType type, Situation situation, int playSrcIdx = -1);
		private bool Remark(CharacterBase chara, TalkType type, Situation situation, int playSrcIdx);
		private bool Reply(CharacterBase chara, CharacterBase companion, TalkType type, Situation situation);
		private List<CharaTalkElement> GetCharaTalkElement(int charaId, TalkType type, Situation situation);
		private string GetTalkCueName(CharacterBase chara, Situation situation, int idx);
		private bool NotifyUI(CharacterBase chara, string text, bool isSrc, string voice, Situation situation, CharacterBase companion = null, bool waitVoiceEnd = false);
		private CharaDialogueUI.Balloon GetBalloon(Situation situation);
		public static int GetFaceIdToCharaId(int faceId);
		public Material FindFaceMaterial(int faceId);
		private void CheckRareEnemy();
		private void CheckPowerfulEnemy();
		private bool IsEnable();
		[CompilerGenerated]
		private void _SetDPMaxAction_b__23_0();
	}
}
