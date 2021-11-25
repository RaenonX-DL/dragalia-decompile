using System.Collections.Generic;
using System.Runtime.InteropServices;
using Gluon.Master;
using UnityEngine;

namespace Gluon
{
	public class CharacterTalkCtrl
	{
		public enum TalkType
		{
			None,
			CrossTalk,
			Soliloquy
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
			Interval = 0xF
		}

		private class TalkData
		{
			public CharacterBase src;

			public CharacterBase dst;

			public TalkType type;

			public Situation situation;

			public float delaySec;

			public TalkData(CharacterBase src, CharacterBase dst, TalkType type, Situation situation, float delaySec)
			{
			}
		}

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

		public void Initialize()
		{
		}

		public void Update()
		{
		}

		public void ClearRegisteredTalk()
		{
		}

		public int GetRegisteredTalkCount()
		{
			return default(int);
		}

		public void SetDPMaxAction()
		{
		}

		public void AddEnemyDeadEvent()
		{
		}

		private void EnemyDeadEvent(EnemyCharacter deadEnemy)
		{
		}

		public void Register(CharacterBase srcChara, CharacterBase dstChara, TalkType type, Situation situation, float delaySec = 0f)
		{
		}

		public void RegisterRandom(Situation situation, [Optional] List<CharacterBase> exceptCharas)
		{
		}

		private bool PlayInterval()
		{
			return default(bool);
		}

		private void AddTalk(CharacterBase srcChara, TalkData talk)
		{
		}

		private bool Play(CharacterBase srcChara, CharacterBase dstChara, TalkType type, Situation situation, int playSrcIdx = -1)
		{
			return default(bool);
		}

		private bool Remark(CharacterBase chara, TalkType type, Situation situation, int playSrcIdx)
		{
			return default(bool);
		}

		private bool Reply(CharacterBase chara, CharacterBase companion, TalkType type, Situation situation)
		{
			return default(bool);
		}

		public static List<CharaTalkElement> GetCharaTalkElement(int charaId, TalkType type, Situation situation)
		{
			return null;
		}

		private string GetTalkCueName(CharacterBase chara, Situation situation, int idx)
		{
			return null;
		}

		private bool NotifyUI(CharacterBase chara, string text, bool isSrc, string voice, Situation situation, [Optional] CharacterBase companion, bool waitVoiceEnd = false)
		{
			return default(bool);
		}

		private CharaDialogueUI.Balloon GetBalloon(Situation situation)
		{
			return default(CharaDialogueUI.Balloon);
		}

		public static int GetFaceIdToCharaId(int faceId)
		{
			return default(int);
		}

		public Material FindFaceMaterial(int faceId)
		{
			return null;
		}

		private void CheckRareEnemy()
		{
		}

		private void CheckPowerfulEnemy()
		{
		}

		private bool IsEnable()
		{
			return default(bool);
		}
	}
}
