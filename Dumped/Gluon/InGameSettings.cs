using System;
using System.Collections.Generic;
using Gluon.GraphicParameter;
using UnityEngine;

namespace Gluon
{
	[CreateAssetMenu]
	public class InGameSettings : ScriptableObject
	{
		[Serializable]
		public class RebornParams
		{
			[SerializeField]
			[Header("HPå\u009b\u009eå¾©å\u0089²å\u0090\u0088ï¼\u00880ï½\u009e1.0ï¼\u0089")]
			public float hpRatio;

			[SerializeField]
			[Header("å¾\u0085æ©\u009fæ\u0099\u0082é\u0096\u0093ï¼\u0088ç§\u0092ï¼\u0089")]
			public float waitingSec;

			[SerializeField]
			[Header("ç\u0084¡æ\u0095µæ\u0099\u0082é\u0096\u0093ï¼\u0088ç§\u0092ï¼\u0089")]
			public float invincibleSec;

			[SerializeField]
			[Header("ã\u0083\u009aã\u0083\u008aã\u0083«ã\u0083\u0086ã\u0082£ç\u0094\u00a8ã\u0083\u0087ã\u0083\u0090ã\u0083\u0095ã\u0081®ActionConditionID")]
			public int debuffId;
		}

		[Serializable]
		public class UnitScaleParam
		{
			[SerializeField]
			[Header("ã\u0083¦ã\u0083\u008bã\u0083\u0083ã\u0083\u0088ã\u0083¢ã\u0083\u0087ã\u0083«ID")]
			public string modelId;

			[SerializeField]
			[Header("ã\u0082¹ã\u0082±ã\u0083¼ã\u0083«å\u0080¤")]
			public float scale;
		}

		[Serializable]
		public class PlayerAIParam
		{
			[Serializable]
			public class ModeParam
			{
				[SerializeField]
				[Header("ã\u0083¢ã\u0083¼ã\u0083\u0089ã\u0083\u0081ã\u0082§ã\u0083³ã\u0082\u00b8ã\u0081®ã\u0083\u0088ã\u0083ªã\u0082¬ã\u0083¼ã\u0081\u00a8ã\u0081ªã\u0082\u008bã\u0082¹ã\u0082­ã\u0083«ID")]
				public string skillId;

				[SerializeField]
				[Header("â\u0086\u0091ã\u0081®ã\u0082¹ã\u0082­ã\u0083«ã\u0082\u0092ä½\u0095å\u009b\u009eä½¿ã\u0081£ã\u0081\u009fã\u0082\u0089ã\u0083¢ã\u0083¼ã\u0083\u0089ã\u0083\u0081ã\u0082§ã\u0083³ã\u0082\u00b8ã\u0081\u0099ã\u0082\u008bã\u0081\u008b")]
				public int count;
			}

			[Serializable]
			public class DisableMoveParam
			{
				[SerializeField]
				[Header("DisableMoveã\u0083\u0087ã\u0083\u0090ã\u0083\u0095ã\u0082\u0092è§£é\u0099¤ã\u0081§ã\u0081\u008dã\u0082\u008bã\u0082¢ã\u0082\u00afã\u0082·ã\u0083§ã\u0083³ID")]
				public int actionId;

				[SerializeField]
				[Header("DisableMoveã\u0083\u0087ã\u0083\u0090ã\u0083\u0095ã\u0081\u008cå\u0088\u0087ã\u0082\u008cã\u0082\u008bä½\u0095ç§\u0092å\u0089\u008dã\u0081§ã\u0082¢ã\u0082\u00afã\u0082·ã\u0083§ã\u0083³ã\u0082\u0092ç\u0099ºå\u008b\u0095ã\u0081\u0099ã\u0082\u008bã\u0081\u008bï¼\u0088ç§\u0092ï¼\u0089")]
				public float durationSec;

				[SerializeField]
				[Header("DisableMoveã\u0083\u0087ã\u0083\u0090ã\u0083\u0095ã\u0082\u0092æ\u008c\u0087å®\u009aã\u0081\u0099ã\u0082\u008bã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ID")]
				public int buffIconId;
			}

			[SerializeField]
			[Header("ã\u0082­ã\u0083£ã\u0083©IDï¼\u0088CharaDataã\u0081®IDï¼\u0089")]
			public string charaId;

			[SerializeField]
			[Header("AIã\u0082¿ã\u0082¤ã\u0083\u0097ï¼\u0088Normal:é\u0080\u009aå\u00b8\u00b8 Burst_00:BAå\u0084ªå\u0085\u0088 Mode_00:ï¼\u0089")]
			public PlayerAIType type;

			[SerializeField]
			[Header("AIã\u0082¿ã\u0082¤ã\u0083\u0097Mode_00ç\u0094\u00a8ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿")]
			public ModeParam[] modeParams;

			[SerializeField]
			[Header("AIã\u0082¿ã\u0082¤ã\u0083\u0097DisableMove_00ç\u0094\u00a8ã\u0083\u0091ã\u0083©ã\u0083¡ã\u0083¼ã\u0082¿")]
			public DisableMoveParam disableMoveParam;

			[SerializeField]
			[Header("BAã\u0083\u0081ã\u0083£ã\u0083¼ã\u0082\u00b8çµ\u0082äº\u0086å¾\u008cã\u0081®å»¶é\u0095·æ\u0099\u0082é\u0096\u0093")]
			public float overrideChargeWaitTime;
		}

		public enum PlayerAIType
		{
			Normal,
			Burst_00,
			Mode_00,
			DisableMove_00
		}

		[Serializable]
		public class WalkingParam
		{
			[Serializable]
			public class BallLotteryTable
			{
				[SerializeField]
				[Header("ã\u0083\u009cã\u0083¼ã\u0083«ã\u0082\u0092æ\u008a\u0095ã\u0081\u0092ã\u0082\u008bç¢ºç\u008e\u0087")]
				public int prob_1;

				[SerializeField]
				[Header("ã\u0083\u0089ã\u0083©ã\u0083\u0095ã\u0083«ã\u0082\u0092æ\u008a\u0095ã\u0081\u0092ã\u0082\u008bç¢ºç\u008e\u0087")]
				public int prob_2;

				[SerializeField]
				[Header("ã\u0083\u008aã\u0083¼ã\u0083\u00a0ã\u0082\u0092æ\u008a\u0095ã\u0081\u0092ã\u0082\u008bç¢ºç\u008e\u0087")]
				public int prob_3;

				[SerializeField]
				[Header("ã\u0082\u0080ã\u0081«ã\u0082\u0080ã\u0081«ã\u0082\u0092æ\u008a\u0095ã\u0081\u0092ã\u0082\u008bç¢ºç\u008e\u0087")]
				public int prob_4;
			}

			[Serializable]
			public class ChangePartsData
			{
				[SerializeField]
				[Header("ã\u0082­ã\u0083£ã\u0083©ID")]
				public int charaId;

				[SerializeField]
				[Header("ã\u0083\u0091ã\u0083¼ã\u0083\u0084å\u0090\u008d")]
				public string partsName;

				[SerializeField]
				[Header("ã\u0083\u0091ã\u0083¼ã\u0083\u0084No")]
				public RenderPartsData.PartsNo partsNo;
			}

			[SerializeField]
			[Header("ã\u0082­ã\u0083£ã\u0083©ã\u0081\u008cæ\u008a\u0095ã\u0081\u0092ã\u0082\u008bã\u0083¢ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ä\u00b8­ã\u0081«ã\u0082«ã\u0083¡ã\u0083©ã\u0081®ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0082«ã\u0082¹ã\u0081\u008cç\u008a¬ã\u0081«ç§»ã\u0082\u008bã\u0082¿ã\u0082¤ã\u0083\u009fã\u0083³ã\u0082°ï¼\u00880ï½\u009e1.0ï¼\u0089")]
			public float cameraFocusTiming;

			[SerializeField]
			[Header("ç\u008a¬ã\u0081\u008cç\u009b®ç\u009a\u0084å\u009c°ã\u0081\u00b8ç§»å\u008b\u0095ã\u0081\u0099ã\u0082\u008bã\u0081\u00a8ã\u0081\u008dã\u0081®å\u0088°é\u0081\u0094è·\u009dé\u009b¢ã\u0083\u009eã\u0083¼ã\u0082\u00b8ã\u0083³")]
			public float moveMargin;

			[SerializeField]
			[Header("ç\u008a¬ã\u0081\u008cã\u0083\u009cã\u0083¼ã\u0083«ã\u0082\u0092æ\u008b¾ã\u0081£ã\u0081¦ã\u0082­ã\u0083£ã\u0083©ã\u0081«æ\u00b8¡ã\u0081\u009dã\u0081\u0086ã\u0081\u00a8æ\u0088»ã\u0081£ã\u0081¦ã\u0081\u008fã\u0082\u008bã\u0081\u00a8ã\u0081\u008dã\u0081®å\u0088°é\u0081\u0094è·\u009dé\u009b¢ã\u0083\u009eã\u0083¼ã\u0082\u00b8ã\u0083³")]
			public float moveMargin_back;

			[SerializeField]
			[Header("ç\u008a¬ã\u0081\u008cã\u0081\u008aåº§ã\u0082\u008aã\u0083¢ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0081\u0099ã\u0082\u008bã\u0081\u00a8ã\u0081\u008dã\u0081®ã\u0083\u0096ã\u0083¬ã\u0083³ã\u0083\u0089ç§\u0092æ\u0095°")]
			public float motionBlendSec_wait;

			[SerializeField]
			[Header("ç\u008a¬ã\u0081\u008cæ­©ã\u0081\u008dã\u0081\u008bã\u0082\u0089èµ°ã\u0082\u008aã\u0081\u00b8é\u0081·ç§»ã\u0081\u0099ã\u0082\u008bã\u0081¾ã\u0081§ã\u0081®ç§\u0092æ\u0095°")]
			public float runTransitionSec;

			[SerializeField]
			[Header("ç\u008a¬ã\u0081\u008cã\u0083\u009cã\u0083¼ã\u0083«ã\u0082\u0092ã\u0082­ã\u0083£ã\u0083\u0083ã\u0083\u0081ã\u0081§ã\u0081\u008dã\u0081ªã\u0081\u0084ã\u0081\u00a8ã\u0081\u008dã\u0081«è«¦ã\u0082\u0081ã\u0082\u008bã\u0081¾ã\u0081§ã\u0081®ç§\u0092æ\u0095°")]
			public float giveUpCatchSec;

			[SerializeField]
			[Header("æ­©ã\u0081\u008dã\u0081®ç§»å\u008b\u0095ã\u0082¹ã\u0083\u0094ã\u0083¼ã\u0083\u0089")]
			public float moveSpeed;

			[SerializeField]
			[Header("èµ°ã\u0082\u008aã\u0081®ã\u0082¹ã\u0083\u0094ã\u0083¼ã\u0083\u0089ã\u0081\u00afæ­©ã\u0081\u008dã\u0081®ä½\u0095å\u0080\u008dã\u0081\u008b")]
			public float dashSpeedRatio;

			[SerializeField]
			[Header("ã\u0083\u009cã\u0083¼ã\u0083«ã\u0081®æ\u008a½é\u0081\u00b8ç¢ºç\u008e\u0087ã\u0083\u0086ã\u0083¼ã\u0083\u0096ã\u0083«ï¼\u0088å\u0090\u0084ã\u0083\u0086ã\u0083¼ã\u0083\u0096ã\u0083«ã\u0081\u00afè¶³ã\u0081\u0097ã\u0081¦100ã\u0081«ã\u0081ªã\u0082\u008bã\u0082\u0088ã\u0081\u0086ã\u0081«å\u0080¤ã\u0082\u0092è\u00a8­å®\u009aã\u0081\u0097ã\u0081¦ã\u0081\u008fã\u0081\u00a0ã\u0081\u0095ã\u0081\u0084ï¼\u0089")]
			public BallLotteryTable[] ballLotteryTables;

			[SerializeField]
			[Header("ç\u009c\u00a0ã\u0082\u008aã\u0082¹ã\u0082­ã\u0083«ã\u0081®SkillDataId")]
			public int sleepSkillDataId;

			[SerializeField]
			[Header("ç\u0089¹æ®\u008aç«\u009cå\u008c\u0096ã\u0083\u0089ã\u0083©ã\u0082\u00b4ã\u0083³ã\u0081\u00a8ã\u0082­ã\u0083£ã\u0083©ã\u0082\u0092å\u0090\u008cæ\u0099\u0082ã\u0081«è¡\u00a8ç¤ºã\u0081\u0095ã\u0081\u009bã\u0081ªã\u0081\u0084ã\u0082­ã\u0083£ã\u0083©ã\u0083ªã\u0082¹ã\u0083\u0088")]
			public List<int> existsOnlyCharaOrDragonList;

			[SerializeField]
			[Header("ã\u0083\u0091ã\u0083¼ã\u0083\u0084å\u0088\u0087ã\u0082\u008aæ\u009b¿ã\u0081\u0088ã\u0082­ã\u0083£ã\u0083©ã\u0083ªã\u0082¹ã\u0083\u0088ï¼\u0088ã\u0083\u0089ã\u0083©ã\u0082\u00b4ã\u0083³ã\u0082\u0092è£\u0085å\u0082\u0099ã\u0081\u0097ã\u0081\u009fã\u0081\u00a8ã\u0081\u008dã\u0081\u00a0ã\u0081\u0091å®\u009fè¡\u008cã\u0081\u0095ã\u0082\u008cã\u0082\u008bï¼\u0089")]
			public List<ChangePartsData> changePartsList;

			[SerializeField]
			[Header("ç«\u009cå\u008c\u0096ã\u0082¢ã\u0082\u00afã\u0082·ã\u0083§ã\u0083³ã\u0082\u0092å®\u009fè¡\u008cã\u0081\u0095ã\u0081\u009bã\u0082\u008bã\u0083\u0089ã\u0083©ã\u0082\u00b4ã\u0083³ã\u0083ªã\u0082¹ã\u0083\u0088")]
			public List<int> needsDragonTransformActionDragons;
		}

		[Serializable]
		public class DragonRelayParam
		{
			[SerializeField]
			[Header("ã\u0082­ã\u0083£ã\u0083©ã\u0083\u0081ã\u0082§ã\u0083³ã\u0082\u00b8ã\u0081\u0099ã\u0082\u008bã\u0081¾ã\u0081§ã\u0081®ç§\u0092æ\u0095°")]
			public float beforeCharaChangeSec;

			[SerializeField]
			[Header("ã\u0082­ã\u0083£ã\u0083©ã\u0083\u0081ã\u0082§ã\u0083³ã\u0082\u00b8ã\u0081\u0097ã\u0081¦ã\u0081\u008bã\u0082\u0089ã\u0081®ç§\u0092æ\u0095°")]
			public float afterCharaChangeSec;
		}

		[Serializable]
		public class SwitchParam
		{
			[SerializeField]
			[Header("ã\u0083\u009eã\u0083«ã\u0083\u0081æ\u0099\u0082ã\u0081«ã\u0082\u00a8ã\u0083\u008dã\u0083\u009fã\u0083¼å\u0088\u009dæ\u009c\u009få\u008c\u0096å\u0089\u008dã\u0081«å\u008f¤ã\u0081\u0084é\u0080\u009aä¿¡ã\u0082\u0092ã\u0082\u00afã\u0083ªã\u0082¢ã\u0081\u0099ã\u0082\u008bå\u0087¦ç\u0090\u0086ã\u0082\u0092ã\u0082ªã\u0083\u0095ã\u0082\u008b")]
			public bool disableClearMultiOldEventsBeforeInitializeEnemy;

			[SerializeField]
			[Header("ã\u0083\u0090ã\u0083¼ã\u0082¹ã\u0083\u0088æ\u0099\u0082ã\u0081®ã\u0082«ã\u0083¡ã\u0083©æ\u008c\u0099å\u008b\u0095ã\u0082\u0092ver140ã\u0081®æ\u008c\u0099å\u008b\u0095ã\u0081«æ\u0088»ã\u0081\u0099")]
			public bool revertCheckBurstForCamera;

			[SerializeField]
			[Header("ã\u0082ªã\u0083¼ã\u0083©ã\u0083¬ã\u0083\u0099ã\u0083«ã\u0083\u0080ã\u0082¦ã\u0083³å\u008f\u00afå\u0090¦")]
			public bool auraEnableLevelDown;

			[SerializeField]
			[Header("ã\u0082\u00a8ã\u0083\u008dã\u0083\u009fã\u0083¼ç\u0094\u009fæ\u0088\u0090æ\u0099\u0082ã\u0081®ã\u0083¢ã\u0083\u0087ã\u0083«ã\u0082¿ã\u0082¤ã\u0083\u0097ã\u0082\u0092ModelType.Normalã\u0081«å¤\u0089æ\u009b\u00b4ã\u0081\u0099ã\u0082\u008b")]
			public bool isEnemyModelTypeNormalOnCreate;

			[SerializeField]
			[Header("Followerã\u0081\u008cBAã\u0083\u0081ã\u0083£ã\u0083¼ã\u0082\u00b8æ\u0099\u0082ã\u0081«ã\u0082¿ã\u0083¼ã\u0082²ã\u0083\u0083ã\u0083\u0088ã\u0082\u0092å¤\u0089æ\u009b\u00b4ã\u0081\u0095ã\u0081\u009bã\u0081ªã\u0081\u0084")]
			public bool isFollowerChargeTargetFixed;

			[SerializeField]
			[Header("ã\u0082¹ã\u0082­ã\u0083«ã\u0082«ã\u0083\u0083ã\u0083\u0088ã\u0082¤ã\u0083³ã\u0082«ã\u0083¡ã\u0083©ã\u0081§ä»\u0096ã\u0081®ã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0082\u0092é\u009d\u009eè¡\u00a8ç¤ºã\u0081«ã\u0081\u0099ã\u0082\u008b")]
			public bool enableHideEffectsForSkillCutInCamera;

			[SerializeField]
			[Header("FollowerStateIdleã\u0081§idleã\u0083¢ã\u0083¼ã\u0082·ã\u0083§ã\u0083³å\u0086\u008dç\u0094\u009fæ\u0099\u0082ã\u0081«æ\u0097¢ã\u0081«å\u0086\u008dç\u0094\u009fä\u00b8­ã\u0081\u008bã\u0081®ã\u0083\u0081ã\u0082§ã\u0083\u0083ã\u0082\u00afã\u0082\u0092ã\u0081\u0097ã\u0081ªã\u0081\u0084")]
			public bool disableCheckFollowerStateIdleMotion;

			[SerializeField]
			[Header("refs #362590ã\u0081§ã\u0081\u0084ã\u0082\u008cã\u0081\u009fã\u0083\u0089ã\u0083¬ã\u0082¤ã\u0083³ã\u0081®ä\u00b8\u008då\u0085·å\u0090\u0088ä¿®æ­£ã\u0082\u0092é\u0081©ç\u0094\u00a8ã\u0081\u0097ã\u0081ªã\u0081\u0084")]
			public bool disableDrainHitCharasBugFix;
		}

		[Serializable]
		public class CameraParam
		{
			[SerializeField]
			[Header("ã\u0082³ã\u0083³ã\u0083\u0086ã\u0082£ã\u0083\u008bã\u0083¥ã\u0083¼æ\u0099\u0082ã\u0081®ã\u0082«ã\u0083¡ã\u0083©å\u0088\u0087ã\u0082\u008aæ\u009b¿ã\u0081\u0088ã\u0082\u0092ä\u00b8\u0080ç\u009e¬ã\u0081§ã\u0082\u0084ã\u0082\u008bã\u0082\u00afã\u0082\u00a8ã\u0082¹ã\u0083\u0088IDã\u0083ªã\u0082¹ã\u0083\u0088")]
			public List<int> continueCameraChangeInstantlyQuestIds;

			[SerializeField]
			[Header("ã\u0082¹ã\u0082­ã\u0083«ã\u0082«ã\u0083\u0083ã\u0083\u0088ã\u0082¤ã\u0083³ã\u0082«ã\u0083¡ã\u0083©ã\u0081§é\u009d\u009eè¡\u00a8ç¤ºå\u00af¾è±¡å¤\u0096ã\u0081«ã\u0081\u0099ã\u0082\u008bã\u0082\u00a8ã\u0083\u0095ã\u0082§ã\u0082\u00afã\u0083\u0088ã\u0083ªã\u0082¹ã\u0083\u0088ï¼\u0088å\u0089\u008dæ\u0096¹ä\u00b8\u0080è\u0087\u00b4ã\u0081§æ¤\u009cç\u00b4¢ï¼\u0089")]
			public List<string> ignoreHideEffectsForSkillCutInCamera;

			[SerializeField]
			[Header("ã\u0082¹ã\u0082­ã\u0083«ã\u0082«ã\u0083\u0083ã\u0083\u0088ã\u0082¤ã\u0083³ã\u0082«ã\u0083¡ã\u0083©ã\u0081§é\u009d\u009eè¡\u00a8ç¤ºå\u00af¾è±¡å¤\u0096ã\u0081«ã\u0081\u0099ã\u0082\u008bã\u0082\u00a8ã\u0083\u008dã\u0083\u009fã\u0083¼ã\u0083ªã\u0082¹ã\u0083\u0088ï¼\u0088EnemyDataã\u0081®IDã\u0081§æ\u008c\u0087å®\u009aï¼\u0089")]
			public List<int> ignoreHideEnemiesForSkillCutInCamera;
		}

		[Serializable]
		public class RaidParam
		{
			[SerializeField]
			[Header("ã\u0083¬ã\u0082¤ã\u0083\u0089ã\u0082¹ã\u0083\u0086ã\u0083¼ã\u0082\u00b8ã\u0081®ã\u0082³ã\u0083ªã\u0082\u00b8ã\u0083§ã\u0083³å\u008d\u008aå¾\u0084ã\u0082\u00920ã\u0081\u00a8ã\u0081\u0097ã\u0081¦æ\u0089±ã\u0081\u0086ã\u0082\u00afã\u0082\u00a8ã\u0082¹ã\u0083\u0088IDã\u0083ªã\u0082¹ã\u0083\u0088")]
			public List<int> useNormalHitCheckQuestIds;

			[SerializeField]
			[Header("ä»\u0096ã\u0083¦ã\u0083¼ã\u0082¶ã\u0083¼ç®¡ç\u0090\u0086ã\u0081®ã\u0082­ã\u0083£ã\u0083©/ã\u0083\u0089ã\u0083©ã\u0082\u00b4ã\u0083³ã\u0081®ã\u0083¢ã\u0083\u0087ã\u0083«ã\u0081\u00a8ã\u0083¢ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0082\u0092å\u0085±æ\u009c\u0089ã\u0081\u0099ã\u0082\u008bã\u0082\u00afã\u0082\u00a8ã\u0082¹ã\u0083\u0088IDã\u0083ªã\u0082¹ã\u0083\u0088")]
			public List<int> useMyModelForOthersModelsQuestIds;

			[SerializeField]
			[Header("ç\u0099»å\u00a0\u00b4ã\u0082«ã\u0083\u0083ã\u0083\u0088ã\u0082·ã\u0083¼ã\u0083³ã\u0082\u0092å¼·å\u0088¶ç\u0084¡å\u008a¹å\u008c\u0096ã\u0081\u0099ã\u0082\u008bã\u0082\u00afã\u0082\u00a8ã\u0082¹ã\u0083\u0088IDã\u0083ªã\u0082¹ã\u0083\u0088")]
			public List<int> cutsceneForceDisabledQuestIds;
		}

		[Serializable]
		public class BRParams
		{
			[SerializeField]
			[Header("ã\u0082­ã\u0083£ã\u0083©ã\u0082\u0092å\u0080\u0092ã\u0081\u0097ã\u0081\u009fã\u0081\u00a8ã\u0081\u008dã\u0081«å\u009bºå®\u009aã\u0081§ã\u0083\u0089ã\u0083­ã\u0083\u0083ã\u0083\u0097ã\u0081\u0095ã\u0081\u009bã\u0082\u008bã\u0082¢ã\u0082¤ã\u0083\u0086ã\u0083\u00a0")]
			public List<BattleRoyalDungeonItem> fixedDropItemsOnCharaDead;

			[SerializeField]
			[Header("ã\u0082­ã\u0083£ã\u0083©ã\u0082\u0092å\u0080\u0092ã\u0081\u0097ã\u0081\u009fã\u0081\u00a8ã\u0081\u008dã\u0081«ã\u0083\u0089ã\u0083­ã\u0083\u0083ã\u0083\u0097ã\u0081\u0095ã\u0081\u009bã\u0082\u008bå\u008f\u0096å¾\u0097æ\u00b8\u0088ã\u0081¿ç\u00a0\u0094ç£\u00a8ç\u009f³ã\u0081®å\u0089²å\u0090\u0088")]
			public float dropWeaponItemsRatioOnCharaDead;

			[SerializeField]
			[Header("ã\u0082­ã\u0083£ã\u0083©ã\u0082\u0092å\u0080\u0092ã\u0081\u0097ã\u0081\u009fã\u0081\u00a8ã\u0081\u008dã\u0081®ç\u008d²å¾\u0097DP")]
			public int dpOnCharaDead;

			[SerializeField]
			[Header("botã\u0081\u008cé\u0080\u0083ã\u0081\u0092ã\u0082\u008bè¡\u008cå\u008b\u0095ã\u0081\u00a8ã\u0081ªã\u0082\u008bHPå\u0089²å\u0090\u0088")]
			public float botEscapeHpRatio;

			[SerializeField]
			[Header("é\u009a\u00a0ã\u0082\u008cèº«ã\u0083\u0090ã\u0083\u0095ä\u00b8­ã\u0081®æ\u0094»æ\u0092\u0083å\u008a\u009bã\u0082¢ã\u0083\u0083ã\u0083\u0097ã\u0081\u008cé\u0081©ç\u0094\u00a8ã\u0081\u0095ã\u0082\u008cã\u0082\u008bã\u0082¹ã\u0082­ã\u0083«ID")]
			public List<int> skillIdsDependsOnHiding;

			[SerializeField]
			[Header("é\u009a\u00a0ã\u0082\u008cèº«ã\u0083\u0090ã\u0083\u0095ä\u00b8­ã\u0081®æ\u0094»æ\u0092\u0083å\u008a\u009bã\u0082¢ã\u0083\u0083ã\u0083\u0097ä¿\u0082æ\u0095°")]
			public float hidingDamageRatio;

			[SerializeField]
			[Header("BGMã\u0082\u0092å¤\u0089æ\u009b\u00b4ã\u0081\u0099ã\u0082\u008bã\u0083\u0088ã\u0083ªã\u0082¬ã\u0083¼ã\u0081\u00a8ã\u0081ªã\u0082\u008bç\u0094\u009få­\u0098è\u0080\u0085æ\u0095°")]
			public int changeBgmCharaCount;

			[SerializeField]
			[Header("BGMã\u0082\u0092å¤\u0089æ\u009b\u00b4ã\u0081\u0099ã\u0082\u008bã\u0083\u0088ã\u0083ªã\u0082¬ã\u0083¼ã\u0081\u00a8ã\u0081ªã\u0082\u008bçµ\u008cé\u0081\u008eç§\u0092æ\u0095°")]
			public float changeBgmElapsedSec;

			[SerializeField]
			[Header("é\u009a\u00a0ã\u0082\u008cèº«ä\u00b8­ã\u0082\u0084ã\u0083\u0096ã\u0083\u0083ã\u0082·ã\u0083¥ã\u0081«æ\u0093\u008dä½\u009cã\u0082­ã\u0083£ã\u0083©ã\u0081\u008cå\u0085¥ã\u0081£ã\u0081\u009fæ\u0099\u0082ã\u0081®ã\u0082­ã\u0083£ã\u0083©ã\u0082«ã\u0083©ã\u0083¼")]
			public Color hidingColor;

			[SerializeField]
			[Header("ã\u0083\u0081ã\u0083¥ã\u0083¼ã\u0083\u0088ã\u0083ªã\u0082¢ã\u0083«ã\u0081§ã\u0081®æ\u0093\u008dä½\u009cã\u0082­ã\u0083£ã\u0083©ã\u0081®è¢«ã\u0083\u0080ã\u0083¡ã\u0083¼ã\u0082\u00b8ã\u0081®å\u0089²å\u0090\u0088ï¼\u00880ï½\u009e1.0ï¼\u0089")]
			public float tutorialDamageRatio;

			[SerializeField]
			[Header("ã\u0083\u0081ã\u0083¥ã\u0083¼ã\u0083\u0088ã\u0083ªã\u0082¢ã\u0083«ã\u0081§ã\u0081®botã\u0081\u008cæ\u0093\u008dä½\u009cã\u0082­ã\u0083£ã\u0083©ã\u0081«å\u0090\u0091ã\u0081\u008bã\u0081\u0084å§\u008bã\u0082\u0081ã\u0082\u008bç§\u0092æ\u0095°")]
			public float tutorialBotStartSec;

			[SerializeField]
			[Header("ã\u0083\u0081ã\u0083¥ã\u0083¼ã\u0083\u0088ã\u0083ªã\u0082¢ã\u0083«ã\u0081§ã\u0081®ã\u0083\u009dã\u0083\u0083ã\u0083\u0097ã\u0081\u0095ã\u0081\u009bã\u0081ªã\u0081\u0084ã\u0082\u00a8ã\u0083\u008dã\u0083\u009fã\u0083¼ã\u0081®EnemyParamIdã\u0083ªã\u0082¹ã\u0083\u0088")]
			public List<int> tutorialCantPosEnemyParamIds;

			[SerializeField]
			[Header("ã\u0083\u0081ã\u0083¥ã\u0083¼ã\u0083\u0088ã\u0083ªã\u0082¢ã\u0083«ã\u0081§ã\u0081®é\u009b£æ\u0098\u0093åº¦å\u009bºå®\u009a")]
			public DungeonManager.eStageDifficulty tutorialStageDifficulty;

			[SerializeField]
			[Header("ã\u0083\u0081ã\u0083¥ã\u0083¼ã\u0083\u0088ã\u0083ªã\u0082¢ã\u0083«ã\u0081§ã\u0081®ã\u0082¹ã\u0082¿ã\u0083¼ã\u0083\u0088ä½\u008dç½®å\u009bºå®\u009a")]
			public int tutorialStartIndex;

			[SerializeField]
			[Header("ã\u0082¢ã\u0082¤ã\u0083\u0086ã\u0083\u00a0ã\u0081\u008cã\u0083\u009dã\u0083\u0083ã\u0083\u0097ã\u0081\u0099ã\u0082\u008bã\u0081\u00a8ã\u0081\u008dã\u0081®è·³ã\u0081­ã\u0082\u008bå\u008d\u008aå¾\u0084")]
			public float itemPopRadius;
		}

		[Serializable]
		public class BuffParams
		{
			[SerializeField]
			[Header("ã\u0083\u0091ã\u0083¼ã\u0083\u0086ã\u0082£ã\u0082¹ã\u0082¤ã\u0083\u0083ã\u0083\u0081ã\u0081§å¼·å\u0088¶è§£é\u0099¤ã\u0081\u0099ã\u0082\u008bã\u0083\u0090ã\u0083\u0095")]
			public List<int> partySwitchResetIds;

			[SerializeField]
			[Header("BAå¼·å\u008c\u0096ã\u0083\u0090ã\u0083\u0095æ\u00b8\u009bè¡°ç\u008e\u0087")]
			public List<float> burstDamageAttenuationRate;
		}

		[Serializable]
		public class AnimatableObjectParam
		{
			[Serializable]
			public class AttachWeaponData
			{
				[SerializeField]
				[Header("ã\u0083\u0097ã\u0083¬ã\u0083\u008fã\u0083\u0096ã\u0083\u0091ã\u0082¹")]
				public string prefabPath;

				[SerializeField]
				[Header("ã\u0082¢ã\u0082¿ã\u0083\u0083ã\u0083\u0081ã\u0081\u0099ã\u0082\u008bã\u0083\u008eã\u0083¼ã\u0083\u0089å\u0090\u008d")]
				public string nodeName;
			}

			[Serializable]
			public class RootAttachObject
			{
				[SerializeField]
				[Header("ã\u0083\u0097ã\u0083¬ã\u0083\u008fã\u0083\u0096")]
				public GameObject prefab;

				[SerializeField]
				[Header("Transformã\u0082\u0092ä\u00b8\u008aæ\u009b\u00b8ã\u0081\u008fã\u0081\u008b")]
				public bool isOverrideTransform;

				[SerializeField]
				[Header("positionã\u0082\u0092ä\u00b8\u008aæ\u009b\u00b8ã\u0081\u008få\u0080¤")]
				public Vector3 overridePos;

				[SerializeField]
				[Header("rotationã\u0082\u0092ä\u00b8\u008aæ\u009b\u00b8ã\u0081\u008få\u0080¤")]
				public Vector3 overrideRot;

				[SerializeField]
				[Header("scaleã\u0082\u0092ä\u00b8\u008aæ\u009b\u00b8ã\u0081\u008få\u0080¤")]
				public Vector3 overrideScale;
			}

			[SerializeField]
			[Header("å\u0090\u008då\u0089\u008d")]
			public string name;

			[SerializeField]
			[Header("ã\u0083¢ã\u0083\u0087ã\u0083«ã\u0083\u0091ã\u0082¹")]
			public string modelPath;

			[SerializeField]
			[Header("ã\u0083¢ã\u0083¼ã\u0082·ã\u0083§ã\u0083³ã\u0083\u0091ã\u0082¹")]
			public string motionPath;

			[SerializeField]
			[Header("ä\u00b8\u008aé\u0099\u0090æ\u0095°ã\u0081\u008cã\u0081\u0082ã\u0082\u008bã\u0081\u008b")]
			public bool enableLimit;

			[SerializeField]
			[Header("ã\u0083\u0097ã\u0083©ã\u0082¹ã\u0081§ç\u0094\u009fæ\u0088\u0090ã\u0081\u0099ã\u0082\u008bã\u0082­ã\u0083£ã\u0083\u0083ã\u0082·ã\u0083¥æ\u0095°")]
			public int chacheCount;

			[SerializeField]
			[Header("æ­¦å\u0099\u00a8ã\u0081®ã\u0082¢ã\u0082¿ã\u0083\u0083ã\u0083\u0081æ\u0083\u0085å\u00a0±")]
			public AttachWeaponData[] attachWeaponData;

			[SerializeField]
			[Header("ã\u0083«ã\u0083¼ã\u0083\u0088ç\u009b\u00b4ä\u00b8\u008bã\u0081«ã\u0081¶ã\u0082\u0089ä\u00b8\u008bã\u0081\u0092ã\u0082\u008bã\u0082¢ã\u0082¿ã\u0083\u0083ã\u0083\u0081ã\u0082ªã\u0083\u0096ã\u0082\u00b8ã\u0082§ã\u0082\u00afã\u0083\u0088")]
			public RootAttachObject[] rootAttachObjects;
		}

		[Serializable]
		public class DefenseQuestParam
		{
			[SerializeField]
			[Header("æ\u009c\u0080çµ\u0082WAVEã\u0081®ã\u0082\u00a8ã\u0083\u008dã\u0083\u009fã\u0083¼ã\u0082\u0092å\u0085\u00a8æ»\u0085ã\u0081\u0095ã\u0081\u009bã\u0081ªã\u0081\u008fã\u0081¦ã\u0082\u0082ã\u0083\u009cã\u0082¹ã\u0082\u00a8ã\u0083ªã\u0082¢ã\u0081«é\u0081·ç§»ã\u0081§ã\u0081\u008dã\u0082\u008bã\u0082\u00afã\u0082\u00a8ã\u0082¹ã\u0083\u0088ã\u0081®IDã\u0081®ã\u0083ªã\u0082¹ã\u0083\u0088")]
			public List<int> openNextAreaGateWithoutFinalWaveClearQuestIds;
		}

		[Serializable]
		public class ScoringQuestParam
		{
			[SerializeField]
			[Header("æ\u0092\u0083é\u0080\u0080ã\u0082¤ã\u0083\u0099ã\u0083³ã\u0083\u0088ã\u0081§ã\u0081®ã\u0082\u00a8ã\u0083\u008dã\u0083\u009fã\u0083¼ã\u0083\u009dã\u0083\u0083ã\u0083\u0097å¾\u008cç\u0084¡æ\u0095µæ\u0099\u0082é\u0096\u0093ï¼\u0088ç§\u0092ï¼\u0089")]
			public float enemyPopInvincibleSec;
		}

		[Serializable]
		public class ExtraParam
		{
			[SerializeField]
			[Header("ï¼\u0088ã\u0083\u009cã\u0082¹é\u0080£æ\u0088¦ã\u0082\u00afã\u0082\u00a8ã\u0082¹ã\u0083\u0088ç\u0094\u00a8ï¼\u0089ã\u0082\u00a8ã\u0083ªã\u0082¢è\u0087ªå\u008b\u0095é\u0081·ç§»ã\u0081¾ã\u0081§ã\u0081®å¾\u0085æ©\u009fæ\u0099\u0082é\u0096\u0093ï¼\u0088ç§\u0092ï¼\u0089")]
			public float autoAreaChangeWaitSec;

			[SerializeField]
			[Header("ã\u0082\u00a8ã\u0083ªã\u0082¢é\u0081·ç§»ã\u0081§ã\u0083\u0090ã\u0083¬ã\u0083\u0083ã\u0083\u0088ã\u0082\u0092æ¶\u0088ã\u0081\u0099ã\u0082¹ã\u0082­ã\u0083«ID")]
			public List<int> deleteBulletOnAreaChangeSkillIds;
		}

		public const string path = "Settings/InGameSettings";

		[Header("å¾©æ\u00b4»é\u0096¢é\u0080£")]
		public RebornParams rebornParam;

		[Header("ã\u0083¦ã\u0083\u008bã\u0083\u0083ã\u0083\u0088ã\u0082¹ã\u0082±ã\u0083¼ã\u0083«é\u0096¢é\u0080£")]
		public UnitScaleParam[] unitScaleParams;

		[Header("ã\u0082­ã\u0083£ã\u0083©AIé\u0096¢é\u0080£")]
		public PlayerAIParam[] playerAIParams;

		[Header("ã\u0082\u00a8ã\u0082¤ã\u0083\u0097ã\u0083ªã\u0083«ã\u0083\u0095ã\u0083¼ã\u0083«ã\u0082\u00afã\u0082\u00a8ã\u0082¹ã\u0083\u0088é\u0096¢é\u0080£")]
		public WalkingParam walkingParam;

		[Header("4ã\u0082­ã\u0083£ã\u0083©ç«\u009cå\u008c\u0096é\u0099\u0090å®\u009aã\u0082\u00afã\u0082\u00a8ã\u0082¹ã\u0083\u0088é\u0096¢é\u0080£")]
		public DragonRelayParam dragonRelayParam;

		[Header("å¤\u009aç\u009b®ç\u009a\u0084ã\u0082¹ã\u0082¤ã\u0083\u0083ã\u0083\u0081")]
		public SwitchParam switches;

		[Header("ã\u0082«ã\u0083¡ã\u0083©é\u0096¢é\u0080£")]
		public CameraParam cameraParam;

		[Header("ã\u0083¬ã\u0082¤ã\u0083\u0089é\u0096¢é\u0080£")]
		public RaidParam raidParam;

		[Header("ã\u0083\u0090ã\u0083\u0088ã\u0083­ã\u0083\u00afé\u0096¢é\u0080£")]
		public BRParams brParams;

		[Header("ã\u0083\u0090ã\u0083\u0095é\u0096¢é\u0080£")]
		public BuffParams buffParam;

		[Header("ã\u0082¢ã\u0083\u008bã\u0083¡ã\u0082¿ã\u0083\u0096ã\u0083«ã\u0082ªã\u0083\u0096ã\u0082\u00b8ã\u0082§ã\u0082\u00afã\u0083\u0088é\u0096¢é\u0080£")]
		public AnimatableObjectParam[] animatableObjectParams;

		[Header("é\u0098²è¡\u009bæ\u0088¦é\u0096¢é\u0080£")]
		public DefenseQuestParam defenseParam;

		[Header("æ\u0092\u0083é\u0080\u0080ã\u0082¤ã\u0083\u0099ã\u0083³ã\u0083\u0088é\u0096¢é\u0080£")]
		public ScoringQuestParam scoringQuestParam;

		[Header("ã\u0081\u009dã\u0081®ä»\u0096")]
		public ExtraParam extraParam;

		public AnimatableObjectParam GetAnimatableObjectParam(string name)
		{
			return null;
		}
	}
}
