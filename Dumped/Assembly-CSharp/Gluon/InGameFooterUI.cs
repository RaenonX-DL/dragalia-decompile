/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InGameFooterUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
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
		[Tooltip]
		public RectTransform[] skillRt;
		[SerializeField]
		[Tooltip]
		public RectTransform skillRefPointRt;
		[SerializeField]
		[Tooltip]
		public RectTransform supportSkillRt;
		[SerializeField]
		[Tooltip]
		public RectTransform stampRt;
		[SerializeField]
		[Tooltip]
		public RectTransform questSkillRt;
		[SerializeField]
		[Tooltip]
		public RectTransform modeSelectRt;
		[SerializeField]
		[Tooltip]
		public RectTransform dragonRt;
		[SerializeField]
		[Tooltip]
		private RectTransform bgRt;
		[SerializeField]
		[Tooltip]
		private RectTransform rebornIconRt;
		[SerializeField]
		[Tooltip]
		private RectTransform unlimitRebornIconRt;
		[SerializeField]
		[Tooltip]
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
		[Header]
		[SerializeField]
		private float rotTime;
		[SerializeField]
		[Tooltip]
		private float rebornIconMerginX;
		[SerializeField]
		[Tooltip]
		private float rebornStartAnimWait;
		[Header]
		[SerializeField]
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
	
		// Constructors
		public InGameFooterUI();
	
		// Methods
		public static InGameFooterUI Create(GameObject parent, int siblingIndex, UnityAction onClick, bool isLeft, bool isUnlimitReborn, int rebornNum);
		private void Initialize(UnityAction onClick, bool isLeft, bool isUnlimitReborn, int rebornNum);
		public override void FastUpdate();
		private void UpdatePos();
		public void Active(bool b);
		public void ApplyCharacter(CharacterBase chara, bool isSelected, bool isForce = false);
		private void SetupHpInfoOnly(CharacterBase chara, bool immediate = false);
		private void SetupDpInfoOnly(DragonCharacter dragon, bool immediate = false);
		public void SetHPGauge(CharacterBase chara, bool immediate);
		public void SetTimeGauge(DragonCharacter dragon, float value, bool immediate);
		public void SetShieldGauge(CharacterBase chara, bool immediate);
		public Vector2 GetButtonPosition();
		public void SetFTU(PlayFTU ftu, PlayFTU.Type ftuType);
		public void VisibleFTU(bool v);
		public void ActiveFTU(bool isActive);
		public void PauseFTU();
		public void DamageFTU();
		private void RotateMark();
		public void VisibleRotateMark(bool v);
		private void SetHpNumber(bool visible, int hp);
		public void AdjustSkillButtonPosition();
		public void OnStatusInfoUIChangePage();
		public void SetEnableRebornIcon(int enableCount);
		public void SetVisibleRebornIcon(int enableCount);
		public void PlayRebornShowAnim();
		public void PlayRebornConsumeAnim(int index, Action onComplete = null);
		public void OnUpdateBlinkAnim(float value);
		[CompilerGenerated]
		private void _Initialize_b__42_0(float rate);
	}
}
