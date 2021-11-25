using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Cute.Core;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Gluon
{
	public class InGameFooterUI : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		private Button changePlayerButton;

		[SerializeField]
		private InGameGaugeUISpriteRenderer hpGauge;

		[SerializeField]
		private InGameGaugeUISpriteRenderer timeGauge;

		[SerializeField]
		private InGameGaugeUISpriteRenderer shieldGauge;

		[SerializeField]
		private ElementIconUISpriteRenderer element;

		[SerializeField]
		[Tooltip("ã\u0082¹ã\u0082­ã\u0083«ã\u0083\u009cã\u0082¿ã\u0083³ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		public RectTransform[] skillRt;

		[SerializeField]
		[Tooltip("ã\u0082¹ã\u0082­ã\u0083«ã\u0083\u009cã\u0082¿ã\u0083³ã\u0081®å\u009fºæº\u0096ç\u0082¹ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		public RectTransform skillRefPointRt;

		[SerializeField]
		[Tooltip("ã\u0082µã\u0083\u009dã\u0083¼ã\u0083\u0088ã\u0082¹ã\u0082­ã\u0083«ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		public RectTransform supportSkillRt;

		[SerializeField]
		[Tooltip("ã\u0082¹ã\u0082¿ã\u0083³ã\u0083\u0097ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		public RectTransform stampRt;

		[SerializeField]
		[Tooltip("ã\u0082\u00afã\u0082\u00a8ã\u0082¹ã\u0083\u0088ã\u0082¹ã\u0082­ã\u0083«ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		public RectTransform questSkillRt;

		[SerializeField]
		[Tooltip("ã\u0083¢ã\u0083¼ã\u0083\u0089ã\u0082»ã\u0083¬ã\u0082\u00afã\u0083\u0088ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		public RectTransform modeSelectRt;

		[SerializeField]
		[Tooltip("ç«\u009cå\u008c\u0096ã\u0083\u009cã\u0082¿ã\u0083³ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		public RectTransform dragonRt;

		[SerializeField]
		[Tooltip("è\u0083\u008cæ\u0099\u00afã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform bgRt;

		[SerializeField]
		[Tooltip("å¾©æ\u00b4»ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform rebornIconRt;

		[SerializeField]
		[Tooltip("ç\u0084¡å\u0088¶é\u0099\u0090å¾©æ\u00b4»ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		private RectTransform unlimitRebornIconRt;

		[SerializeField]
		[Tooltip("å\u008f\u008dè»¢ç§»å\u008b\u0095ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		public RectTransform inversionMoveRt;

		[SerializeField]
		private Color skillBackColor;

		[SerializeField]
		private SpriteRenderer[] hpNumberSpriteRenderer;

		[SerializeField]
		private RectTransform rotRt;

		[SerializeField]
		private RotZControlUI rotMark;

		[SerializeField]
		private PlayerStatusInfoUI statusInfoUI;

		[SerializeField]
		[Header("parameter")]
		private float rotTime;

		[SerializeField]
		[Tooltip("å¾©æ\u00b4»ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0081®é\u0085\u008dç½®é\u0096\u0093é\u009a\u0094")]
		private float rebornIconMerginX;

		[SerializeField]
		[Tooltip("å¾©æ\u00b4»ã\u0082¢ã\u0082¤ã\u0082³ã\u0083³ã\u0081®é\u0096\u008bå§\u008bã\u0082¢ã\u0083\u008bã\u0083¡å¾\u0085æ©\u009fæ\u0099\u0082é\u0096\u0093")]
		private float rebornStartAnimWait;

		[SerializeField]
		[Header("resource")]
		private Sprite[] hpNumberSprite;

		private bool isDragon;

		private CharacterBase owner;

		private CharacterSelector csDragon;

		private Material currentMaterial;

		private Material currentDamageMaterial;

		private Material humanMaterial;

		private Material dragonMaterial;

		private PlayFTU ftu;

		private PlayFTU.Type ftuType;

		private List<PlayFTU.MaterialInfo> ftuMaterial;

		private List<RebornLifeIconUI> rebornIconList;

		private bool isLeft;

		private float moveDirection;

		private float moveDistance;

		private float screenAdjustScale;

		private const int FtuMaterialNum = 2;

		public static InGameFooterUI Create(GameObject parent, int siblingIndex, UnityAction onClick, bool isLeft, bool isUnlimitReborn, int rebornNum)
		{
			return null;
		}

		private void Initialize(UnityAction onClick, bool isLeft, bool isUnlimitReborn, int rebornNum)
		{
		}

		public override void FastUpdate()
		{
		}

		private void UpdatePos()
		{
		}

		public void Active(bool b)
		{
		}

		public void ApplyCharacter(CharacterBase chara, bool isSelected, bool isForce = false)
		{
		}

		private void SetupHpInfoOnly(CharacterBase chara, bool immediate = false)
		{
		}

		private void SetupDpInfoOnly(DragonCharacter dragon, bool immediate = false)
		{
		}

		public void SetHPGauge(CharacterBase chara, bool immediate)
		{
		}

		public void SetTimeGauge(DragonCharacter dragon, float value, bool immediate)
		{
		}

		public void SetShieldGauge(CharacterBase chara, bool immediate)
		{
		}

		public Vector2 GetButtonPosition()
		{
			return default(Vector2);
		}

		public void SetFTU(PlayFTU ftu, PlayFTU.Type ftuType)
		{
		}

		public void VisibleFTU(bool v)
		{
		}

		public void ActiveFTU(bool isActive)
		{
		}

		public void PauseFTU()
		{
		}

		public void DamageFTU()
		{
		}

		private void RotateMark()
		{
		}

		public void VisibleRotateMark(bool v)
		{
		}

		private void SetHpNumber(bool visible, int hp)
		{
		}

		public void AdjustSkillButtonPosition()
		{
		}

		public void OnStatusInfoUIChangePage()
		{
		}

		public void SetEnableRebornIcon(int enableCount)
		{
		}

		public void SetVisibleRebornIcon(int enableCount)
		{
		}

		public void PlayRebornShowAnim()
		{
		}

		public void PlayRebornConsumeAnim(int index, [Optional] Action onComplete)
		{
		}

		public void OnUpdateBlinkAnim(float value)
		{
		}
	}
}
