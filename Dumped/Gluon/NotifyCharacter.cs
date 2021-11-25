using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace Gluon
{
	public class NotifyCharacter
	{
		public enum NoticeType
		{
			GeneratePlayer,
			SetPlayer,
			PlayerTransform,
			GeneratePlayerMulti,
			UpdateHP,
			Damage,
			NoDamage,
			Death,
			Combo,
			ChangeFootMark,
			EmotionMark,
			TargetEnemy,
			InactiveFootMark,
			ActiveFootMark,
			SetDP,
			StopQuestEffect,
			CharaDialogue,
			CharaDialogueText,
			CharaDialogueClose,
			CharaDialogueQueueClear,
			CharaDialogueNPC,
			PlayerAttack,
			PlayerDodge,
			ChargeStart,
			ChargeEnd,
			ChargeCancel,
			UpdateBreak,
			CountDownAuto,
			StartPlay,
			EndPlay,
			SystemMessage,
			SystemMessageOpen,
			SystemMessageClose,
			OpenLoading,
			CloseLoading,
			OpenPartBreak,
			ClosePartBreak,
			SetPlayerPartBreak,
			TimeUpWarning,
			DispDragonButton,
			DisconnectedDialog,
			OtherPlayerRetireDialog,
			UnexpectedDisconnection,
			OtherPlayerLeaveAloneDialog,
			RankingDisabled,
			UpdateRebornTimeCount,
			SumUpTotalDamageDisabled
		}

		public class GeneratePlayerParam
		{
			public DragonCharacter dragon;

			public int partyPosition;

			public InGameDef.SwitchPartyNoList switchPartyNo;

			public bool support;
		}

		public class GeneratePlayerMultiParam : GeneratePlayerParam
		{
			public bool standardQuest;

			public bool isPartyMember;
		}

		public class DisconnectedDialogParam
		{
			public string name;

			public int actorId;

			public string label;
		}

		public class Damage
		{
			public int damage;

			public Vector3 position;

			public bool isCritical;

			public bool isDragon;

			public DamageNumUI.DamageType damageType;

			public DamageNumUI.Target target;

			public int splitDamageCnt;

			public int splitCondition;

			public CharacterBase attacker;

			public bool isSkipDamageUI;

			public float delaySec;

			public AbnormalStatusType abnormalStatusType;

			public CharacterBuffType buffType;

			public int buffIconId;

			public bool isDebuffExtraDamage;

			public bool isAdditionalAttackDamage;
		}

		public class NoDamage
		{
			public Vector3 position;

			public DamageFigUI.NoDamageType noDamageType;
		}

		public class RecoveryHp
		{
			public int value;

			public Vector3 position;
		}

		public enum EmotionType
		{
			Sight1,
			Sight2,
			Anger1,
			Anger2,
			Attack1,
			Attack2
		}

		public struct EmotionParam
		{
			public EmotionType type;

			public float scale;

			public float posY;

			public EmotionParam(EmotionType _type, float _scale, float _posY = 0f)
			{
			}
		}

		public struct SkillCutInParam
		{
			public string name;

			public int index;

			public Action<PlayFTU> endFunction;

			public SkillCutInParam(string _name, int _index, Action<PlayFTU> _endFunction)
			{
			}

			public void Set(string _name, int _index, Action<PlayFTU> _endFunction)
			{
			}
		}

		public class CharaDialogueParam
		{
			public string text;

			public bool leftIcon;

			public string voice;

			public bool waitVoiceEnd;

			public bool isManual;

			public CharaDialogueUI.Balloon balloon;

			public CharaDialogueParam(string _text, bool _leftIcon, string _voice, bool _isManual = false, CharaDialogueUI.Balloon _balloon = CharaDialogueUI.Balloon.Standard, bool _waitVoiceEnd = false)
			{
			}
		}

		public class CharaDialogueTextParam
		{
			public string text;

			public string voice;
		}

		public class CharaDialogueNPCParam
		{
			public int faceId;

			public string text;

			public bool leftIcon;

			public string voice;

			public InGameSound.Priority voicePriority;

			public bool waitVoiceEnd;

			public bool fastForward;

			public CharaDialogueUI.Balloon balloon;
		}

		public class CountDownAutoParam
		{
			public float time;

			public Action timeUpFunction;
		}

		public class SystemMessageParam
		{
			public float time;

			public string message;

			public bool isRegistCheck;
		}

		public class SystemMessageOpenParam
		{
			public string message;

			public bool se;
		}

		public class ResultBattleParam
		{
			public string[] name;

			public int[] point;

			public int ownIndex;
		}

		public class UpdateRebornTimerCountParam
		{
			public CharacterBase owner;

			public int elapsed;
		}

		public class OpenPartBreakParam
		{
			public PartBreakUI.Type displayType;

			public int partNum;

			public CharacterBase[] partObj;

			public int[] partType;

			public float[] partRate;

			public bool isChangeBoss;
		}

		public struct OpenPlaceNameParam
		{
			public enum Type
			{
				NormalOpen,
				RichReady,
				RichOpen
			}

			public Type type;

			public string name;

			public string summary;

			public Color summaryColor;

			public float time;

			public int floor;
		}

		public struct SetDPParam
		{
			public bool immediate;

			public bool withEffectAndSE;
		}

		public struct OpenComboParam
		{
			public CharacterBase owner;

			public int value;
		}

		public delegate void NotifyDelegate(CharacterBase sender, NoticeType notice, object param);

		public static readonly string[] noticeTypeNames;

		private static int numNotice;

		private NotifyDelegate[] notifyDelegates;

		private string[] notifyDelegatesNames;

		private static int GetNoticeNum()
		{
			return default(int);
		}

		public void Attach(NoticeType notice, NotifyDelegate func)
		{
		}

		public void Detach(NoticeType notice, NotifyDelegate func)
		{
		}

		public void Detach(NotifyDelegate func)
		{
		}

		public void Detach()
		{
		}

		public void Notify(CharacterBase sender, NoticeType notice, [Optional] object param)
		{
		}
	}
}
