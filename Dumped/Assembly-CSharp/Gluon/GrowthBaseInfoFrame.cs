/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using FLATOUT.Main;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthBaseInfoFrame : MonoBehaviour
	{
		// Fields
		public UnityEngine.UI.Text baseNameText;
		public UnityEngine.UI.Text plusParamText;
		public LimitStarBase starBase;
		public Image manaStar;
		public Image baseImage;
		public UnityEngine.UI.Text baseLvText;
		public UnityEngine.UI.Text baseMaxLvText;
		public UnityEngine.UI.Text lvInfoText;
		public UnityEngine.UI.Text hpText;
		public UnityEngine.UI.Text atkText;
		public UnityEngine.UI.Text powerText;
		public UnityEngine.UI.Text overExpBase;
		public UnityEngine.UI.Text overExpText;
		public int growExpParam;
		public int growHpPlusParam;
		public int growAtkPlusParam;
		public UnityAction<bool, bool> growAnimationEndCallBack;
		public Coroutine gaugeUpAnimationCoroutine;
		public Image beforeExpGaugeImage;
		public bool isShowTotalExp;
		public bool isPlayGrowEffect;
		public bool isShowPlusParam;
		public Button changeLvInfoButton;
		public Button changePlusParamButton;
		public Button skipTouchGuardForFrame;
		[SerializeField]
		private Slider baseLvSlider;
		[SerializeField]
		private Transform[] starEffectTransform;
		[SerializeField]
		private UnityEngine.UI.Text hpNameText;
		[SerializeField]
		private UnityEngine.UI.Text atkNameText;
		[SerializeField]
		private UnityEngine.UI.Text powerNameText;
		[CompilerGenerated]
		private GrowthBaseInfoData _growthBaseInfoData_k__BackingField;
		private Image nowExpGaugeImage;
		private int _expSliderMax;
		private int _expSliderValue;
		private float animationFillAmount;
		private int animationGrowLv;
		private int animationGrowExp;
		private int growLvParam;
		private int growAtkParam;
		private int growHpParam;
		private int animeExpParam;
		private float beforeNextLvExpGaugeAnchorMax;
		private float beforeTotalExpGaugeAnchorMax;
		private readonly Color growthYellow;
	
		// Properties
		public GrowthBaseInfoData growthBaseInfoData { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public int expSliderMax { get; set; }
		public int expSliderValue { get; set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class _GaugeUpAnimation_d__66 : IEnumerator<object>
		{
			// Fields
			private int __1__state;
			private object __2__current;
			public GrowthBaseInfoFrame __4__this;
			private float _time_5__2;
			private int _paramDiff_5__3;
			private int _oldGaugeup_5__4;
	
			// Properties
			object IEnumerator<System.Object>.Current { [DebuggerHidden] get; }
			object IEnumerator.Current { [DebuggerHidden] get; }
	
			// Constructors
			[DebuggerHidden]
			public _GaugeUpAnimation_d__66(int __1__state);
	
			// Methods
			[DebuggerHidden]
			void IDisposable.Dispose();
			private bool MoveNext();
			[DebuggerHidden]
			void IEnumerator.Reset();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass73_0
		{
			// Fields
			public GrowthBaseInfoFrame __4__this;
			public int index;
			public int total;
			public FlMotion starAnimeMotion;
			public GameObject starAnimation;
	
			// Constructors
			public __c__DisplayClass73_0();
	
			// Methods
			internal void _ShowLimitBreakStarPlus_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass74_0
		{
			// Fields
			public GrowthBaseInfoFrame __4__this;
			public int index;
			public FlMotion starAnimeMotion;
			public GameObject starAnimation;
	
			// Constructors
			public __c__DisplayClass74_0();
	
			// Methods
			internal void _ChangeMaxLimitBreakStar_b__0();
		}
	
		// Constructors
		public GrowthBaseInfoFrame();
	
		// Methods
		private void OnDestroy();
		private void Awake();
		public void SetupBaseData(ulong baseKeyId, bool isUpdate = true);
		private void UpdateBaseStatusInfo();
		private void UpdateLvInfo(int growHpPlus, int growAtkPlus, int growLv);
		private void UpdateStatusParamInfo(int growHp, int growAtk, int growHpPlus, int growAtkPlus);
		private void UpdatePlusParamInfo(int growPlusHp, int growPlusAtk);
		private void UpdateExpGaugeInfo(int expParam, int growLv);
		public void ChangeLvInfo();
		public void ChangePlusInfo();
		public void BaseInfoUpdate(int getExp, int getHpPlus, int getAtkPlus, int overExp);
		public void ResetGrowData();
		public void StartGrowAnimation(bool isRepeat);
		[IteratorStateMachine]
		private IEnumerator GaugeUpAnimation();
		private int easeOutAnimation(float time, int startValue, int paramDiff, float totalTime);
		public void CloseGaugeUpAnimation();
		public void SkillAbilityButtonPressed(int tag);
		private void ShowSkillDetailDialog(int dataId, int level, int maxLevel);
		private void ShowAbilityDetailDialog(int dataId, bool isLockAbility, ElementalType type);
		public void baseIconLongPress();
		public void ShowLimitBreakStarPlus(Transform parentTransform, int index, int total);
		public void ChangeMaxLimitBreakStar(int index);
		public void UpdateGrowthBaseIcon();
	}
}
