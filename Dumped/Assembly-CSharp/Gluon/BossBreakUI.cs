/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class BossBreakUI : MonoBehaviour
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
		private RectTransform adjustRt;
		[SerializeField]
		private RectTransform breakGaugeRt;
		[SerializeField]
		private SpriteRenderer bgHpRtModSprite;
		[SerializeField]
		private SpriteRenderer bgBreakModSprite;
		[SerializeField]
		private SpriteRenderer breakGaugeIcon;
		[SerializeField]
		private BossStatusInfoUI statusInfoUI;
		[SerializeField]
		private RectTransform gaugeEffectRt;
		[SerializeField]
		private RectTransform raidEffectRt;
		private VisibleUIObject rootVisible;
		private VisibleUIObject breakGaugeVisible;
		private VisibleUIObject breakGaugeIconVisible;
		private CharaCircleGaugeMiasmaUI miasmaGaugeUI;
		private InGameFollowLayout followLayout;
		private Sequence sequenceGaugeMove;
		private Sequence sequenceGaugeMod;
		private int lastFishGrade;
	
		// Constructors
		public BossBreakUI();
	
		// Methods
		public static BossBreakUI Create(GameObject parent, int siblingIndex = -1);
		private void Initialize();
		private void OnDestroy();
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
		[CompilerGenerated]
		private void _Initialize_b__21_0();
		[CompilerGenerated]
		private void _Initialize_b__21_1();
	}
}
