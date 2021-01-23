/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class NotifyCharacter
	{
		// Fields
		public static readonly string[] noticeTypeNames;
		private static int numNotice;
		private NotifyDelegate[] notifyDelegates;
		private string[] notifyDelegatesNames;
	
		// Nested types
		public enum NoticeType
		{
			GeneratePlayer = 0,
			SetPlayer = 1,
			PlayerTransform = 2,
			GeneratePlayerMulti = 3,
			UpdateHP = 4,
			Damage = 5,
			NoDamage = 6,
			Death = 7,
			Combo = 8,
			ChangeFootMark = 9,
			EmotionMark = 10,
			TargetEnemy = 11,
			InactiveFootMark = 12,
			ActiveFootMark = 13,
			SetDP = 14,
			StopQuestEffect = 15,
			CharaDialogue = 16,
			CharaDialogueText = 17,
			CharaDialogueClose = 18,
			CharaDialogueQueueClear = 19,
			CharaDialogueNPC = 20,
			PlayerAttack = 21,
			PlayerDodge = 22,
			ChargeStart = 23,
			ChargeEnd = 24,
			ChargeCancel = 25,
			UpdateBreak = 26,
			CountDownAuto = 27,
			StartPlay = 28,
			EndPlay = 29,
			SystemMessage = 30,
			SystemMessageOpen = 31,
			SystemMessageClose = 32,
			OpenLoading = 33,
			CloseLoading = 34,
			OpenPartBreak = 35,
			ClosePartBreak = 36,
			SetPlayerPartBreak = 37,
			TimeUpWarning = 38,
			DispDragonButton = 39,
			DisconnectedDialog = 40,
			OtherPlayerRetireDialog = 41,
			UnexpectedDisconnection = 42,
			OtherPlayerLeaveAloneDialog = 43,
			RankingDisabled = 44,
			UpdateRebornTimeCount = 45
		}
	
		public class GeneratePlayerParam
		{
			// Fields
			public DragonCharacter dragon;
			public int partyPosition;
			public bool support;
	
			// Constructors
			public GeneratePlayerParam();
		}
	
		public class GeneratePlayerMultiParam : GeneratePlayerParam
		{
			// Fields
			public bool standardQuest;
			public bool isPartyMember;
	
			// Constructors
			public GeneratePlayerMultiParam();
		}
	
		public class DisconnectedDialogParam
		{
			// Fields
			public string name;
			public int actorId;
			public string label;
	
			// Constructors
			public DisconnectedDialogParam();
		}
	
		public class Damage
		{
			// Fields
			public int damage;
			public Vector3 position;
			public bool isCritical;
			public bool isDragon;
			public DamageUICtrl.DamageType damageType;
			public DamageUICtrl.Target target;
			public int splitDamageCnt;
			public int splitCondition;
			public CharacterBase attacker;
			public bool isSkipDamageUI;
			public float delaySec;
			public AbnormalStatusType abnormalStatusType;
			public CharacterBuffType buffType;
			public int uniqueBuffIcon;
			public bool isDebuffExtraDamage;
			public bool isAdditionalAttackDamage;
	
			// Constructors
			public Damage();
		}
	
		public class NoDamage
		{
			// Fields
			public Vector3 position;
			public DamageUICtrl.NoDamageType noDamageType;
	
			// Constructors
			public NoDamage();
		}
	
		public class RecoveryHp
		{
			// Fields
			public int value;
			public Vector3 position;
	
			// Constructors
			public RecoveryHp();
		}
	
		public enum EmotionType
		{
			Sight1 = 0,
			Sight2 = 1,
			Anger1 = 2,
			Anger2 = 3,
			Attack1 = 4,
			Attack2 = 5
		}
	
		public struct EmotionParam
		{
			// Fields
			public EmotionType type;
			public float scale;
			public float posY;
	
			// Constructors
			public EmotionParam(EmotionType _type, float _scale, float _posY = 0f);
		}
	
		public struct SkillCutInParam
		{
			// Fields
			public string name;
			public int index;
			public Action<PlayFTU> endFunction;
	
			// Constructors
			public SkillCutInParam(string _name, int _index, Action<PlayFTU> _endFunction);
		}
	
		public class CharaDialogueParam
		{
			// Fields
			public string text;
			public bool leftIcon;
			public string voice;
			public bool waitVoiceEnd;
			public bool isManual;
			public CharaDialogueUI.Balloon balloon;
	
			// Constructors
			public CharaDialogueParam(string _text, bool _leftIcon, string _voice, bool _isManual = false, CharaDialogueUI.Balloon _balloon = CharaDialogueUI.Balloon.Standard, bool _waitVoiceEnd = false);
		}
	
		public class CharaDialogueTextParam
		{
			// Fields
			public string text;
			public string voice;
	
			// Constructors
			public CharaDialogueTextParam();
		}
	
		public class CharaDialogueNPCParam
		{
			// Fields
			public int faceId;
			public string text;
			public bool leftIcon;
			public string voice;
			public InGameSound.Priority voicePriority;
			public bool waitVoiceEnd;
			public bool fastForward;
			public CharaDialogueUI.Balloon balloon;
	
			// Constructors
			public CharaDialogueNPCParam();
		}
	
		public class CountDownAutoParam
		{
			// Fields
			public float time;
			public Action timeUpFunction;
	
			// Constructors
			public CountDownAutoParam();
		}
	
		public class SystemMessageParam
		{
			// Fields
			public float time;
			public string message;
			public bool isRegistCheck;
	
			// Constructors
			public SystemMessageParam();
		}
	
		public class SystemMessageOpenParam
		{
			// Fields
			public string message;
			public bool se;
	
			// Constructors
			public SystemMessageOpenParam();
		}
	
		public class ResultBattleParam
		{
			// Fields
			public string[] name;
			public int[] point;
			public int ownIndex;
	
			// Constructors
			public ResultBattleParam();
		}
	
		public class UpdateRebornTimerCountParam
		{
			// Fields
			public int actorId;
			public int elapsed;
	
			// Constructors
			public UpdateRebornTimerCountParam();
		}
	
		public class OpenPartBreakParam
		{
			// Fields
			public int num;
			public CharacterBase[] part;
	
			// Constructors
			public OpenPartBreakParam();
		}
	
		public struct OpenPlaceNameParam
		{
			// Fields
			public Type type;
			public string name;
			public string summary;
			public Color summaryColor;
			public float time;
			public int floor;
	
			// Nested types
			public enum Type
			{
				NormalOpen = 0,
				RichReady = 1,
				RichOpen = 2
			}
		}
	
		public struct SetDPParam
		{
			// Fields
			public bool immediate;
			public bool withEffectAndSE;
		}
	
		public delegate void NotifyDelegate(CharacterBase sender, NoticeType notice, object param);
	
		// Constructors
		public NotifyCharacter();
		static NotifyCharacter();
	
		// Methods
		private static int GetNoticeNum();
		public void Attach(NoticeType notice, NotifyDelegate func);
		public void Detach(NoticeType notice, NotifyDelegate func);
		public void Detach(NotifyDelegate func);
		public void Detach();
		public void Notify(CharacterBase sender, NoticeType notice, object param = null);
	}
}
