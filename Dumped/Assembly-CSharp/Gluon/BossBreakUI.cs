/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BossBreakUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private ElementIconUISpriteRenderer elementIcon;
		[SerializeField]
		private UnityEngine.UI.Text nameText;
		[SerializeField]
		private InGameGaugeUISpriteRenderer hpGauge;
		[SerializeField]
		private InGameGaugeUISpriteRenderer breakGauge;
		[SerializeField]
		[Tooltip]
		private RectTransform adjustRt;
		[SerializeField]
		[Tooltip]
		private RectTransform breakGaugeRt;
		[SerializeField]
		[Tooltip]
		private RectTransform hpGaugeShineRootRt;
		[SerializeField]
		[Tooltip]
		private RectTransform hpGaugeShineSubRootRt;
		[SerializeField]
		[Tooltip]
		private RectTransform hpGaugeShineImageAdjustRt;
		[SerializeField]
		[Tooltip]
		private RectTransform hpGaugeShineIconRt;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer bgHpRtModSprite;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer bgBreakModSprite;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer breakGaugeIcon;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer hpGaugeShineBgImage;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer hpGaugeShineGaugeImage;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer hpGaugeShineIconImage;
		[SerializeField]
		[Tooltip]
		private BossStatusInfoUI statusInfoUI;
		[SerializeField]
		[Tooltip]
		private RectTransform gaugeEffectRt;
		[SerializeField]
		[Tooltip]
		private RectTransform raidEffectRt;
		[Header]
		[SerializeField]
		private float hpGaugeShineAdjustStartPosX;
		[SerializeField]
		private float hpGaugeShineAdjustEndPosX;
		private EnemyCharacter owner;
		private VisibleUIObject rootVisible;
		private VisibleUIObject breakGaugeVisible;
		private VisibleUIObject breakGaugeIconVisible;
		private VisibleUIObject hpGaugeShineRootVisible;
		private VisibleUIObject hpGaugeShineSubRootVisible;
		private CharaCircleGaugeMiasmaUI miasmaGaugeUI;
		private InGameFollowLayout followLayout;
		private Sequence seqGaugeMove;
		private Sequence seqGaugeMod;
		private Sequence seqHpGaugeShineIcon;
		private int lastFishGrade;
	
		// Constructors
		public BossBreakUI();
	
		// Methods
		public static BossBreakUI Create(GameObject parent, int siblingIndex = -1);
		private void Initialize();
		private void OnDestroy();
		public override void FastUpdate();
		public void UpdateHpGaugeShine();
		public void Open(CharacterBase chara, ElementalType element, string name, bool hasBreak, float initialHpValue, InGameEventExtendAtlasManager eeAtlasManager);
		private void OpenBreakGauge(float rate);
		public void Close();
		public bool IsVisible();
		public void SetHPValue(float value);
		public void SetBreakValue(float value, bool immediate = false);
		public void GetRaidEffectPosition(ref Vector3 pos);
		public void GetGaugeEffectPosition(ref Vector3 pos);
		public InGameGaugeUISpriteRenderer GetBreakGauge();
		public void OnStatusInfoUIChangePage();
		public CharaCircleGaugeMiasmaUI CreateBossMiasmaGaugeUI(CharacterBase boss);
		public void PlayQuestEffectBreak(float durationTime);
		private void PlayQuestEffectBreakGauge(bool playFromBeginning = true);
		public void StopQuestEffectBreak();
		private void StopQuestEffectBreakGauge(bool isImmediate = false);
		public void PlayQuestEffectOverdrive();
		private void PlayQuestEffectOverdriveGauge(bool playFromBeginning = true);
		public void StopQuestEffectOverdrive();
		private void StopQuestEffectOverdriveGauge(bool isImmediate = false);
		public void PlayQuestEffectBerserk();
		public void StopQuestEffectBerserk();
		public void PlayQuestEffectRaidFishGrade(int grade, Action<PlayFTU> endFunc = null);
		public void StopQuestEffectRaidFishGrade();
		private void StopQuestEffectGauge(PlayFTU.Type type, bool isImmediate);
		public void OnUpdateHpGaugeShineBgFade(float value);
		public void OnUpdateHpGaugeShineGaugeFade(float value);
		public void OnUpdateHpGaugeShineLocalPosX(float value);
		[CompilerGenerated]
		private void _Initialize_b__34_0();
		[CompilerGenerated]
		private void _Initialize_b__34_1();
		[CompilerGenerated]
		private void _Initialize_b__34_2(float t);
		[CompilerGenerated]
		private void _Initialize_b__34_3(float t);
	}
}
