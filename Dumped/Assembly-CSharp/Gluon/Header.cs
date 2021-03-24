/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class Header : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private CircleGaugeGraphic levelGauge;
		[SerializeField]
		private UnityEngine.UI.Text staminaText;
		[SerializeField]
		private UnityEngine.UI.Text rankNumberText;
		[SerializeField]
		private UnityEngine.UI.Text stoneNumText;
		[SerializeField]
		private UnityEngine.UI.Text dragonDiamondNumText;
		[SerializeField]
		private UnityEngine.UI.Text staminaNumText;
		[SerializeField]
		private UnityEngine.UI.Text staminaTimerText;
		[SerializeField]
		private Image staminaTimerImage;
		[SerializeField]
		private RectTransform bpIconOn1;
		[SerializeField]
		private RectTransform bpIconOn2;
		[SerializeField]
		private RectTransform bpIconOff;
		[SerializeField]
		private UnityEngine.UI.Text bpNumText;
		[SerializeField]
		private UnityEngine.UI.Text bpTimerText;
		[SerializeField]
		private Image bpTimerImage;
		[SerializeField]
		private Button dragonDiamondPlusButton;
		[SerializeField]
		private Button staminaPlusButton;
		[SerializeField]
		private Button bpPlusButton;
		[SerializeField]
		private HeaderExpHover[] expHovers;
		[SerializeField]
		private HeaderMissionMessage missionMessage;
		[SerializeField]
		private HeaderPushMessage pushMessage;
		private int updateCount;
		private const int bpDisplayCount = 6;
		private const string staminaSingleNormalColor = "ffffff";
		private const string staminaSingleOverMaxColor = "ffc600";
		private const string staminaMultiNormalColor = "ffffff";
		private const string staminaMultiOverMaxColorOld = "33cccc";
		private const string staminaMultiOverMaxColor = "ffc600";
		private GameObject promotedIAPEnableTester;
		private Sequence staminaTweenSequence;
		private bool isStopUpdate;
		private int stopUpdateCount;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass42_0
		{
			// Fields
			public long tweenValue;
			public Header __4__this;
	
			// Constructors
			public __c__DisplayClass42_0();
	
			// Methods
			internal long _SetSingleStaminaTween_b__0();
			internal void _SetSingleStaminaTween_b__1(long value);
			internal void _SetSingleStaminaTween_b__2();
			internal void _SetSingleStaminaTween_b__3();
		}
	
		// Constructors
		public Header();
	
		// Methods
		private void Awake();
		private void Start();
		private void Update();
		public void ReloadAll(bool isInit = false);
		public void SetRank(int num);
		public void SetExp(int level, int exp);
		public void SetCrystal(int num);
		public void SetDragonDiamond(int num);
		public void SetSingleStamina(long num);
		public void StopUpdate();
		public void RestartUpdate();
		public void SetSingleStaminaTween(long startValue, int addValue);
		public void SetMultiStamina(int num);
		public void UpdateNextStaminaSingleTime();
		public void UpdateNextStaminaMultiTime();
		public void OnDragonDiamondPlusButtonTouched();
		public void OnStaminaPlusButtonTouched();
		public void OnBpPlusButtonTouched();
		public void OnExpHoverAreaDown(int index);
		public void OnExpHoverAreaUp();
		public void SetPlusStoneInteractableState(bool bEnable);
		public void UpdateMissionMessage();
		public void UpdatePushMessage();
		public void SetPushMessageAnimEnable(bool enable);
		private void OnApplicationPause(bool pause);
		public void SetInteractablePlusButtons(bool interactable);
		private void PlusButtonsMaintenance();
		public bool IsDragonDiamondPlusButtonInteractable();
		public bool IsDragonDiamondPlusButtonTopMost();
		[CompilerGenerated]
		private void _OnDragonDiamondPlusButtonTouched_b__46_0();
		[CompilerGenerated]
		private void _OnStaminaPlusButtonTouched_b__47_0();
		[CompilerGenerated]
		private void _OnBpPlusButtonTouched_b__48_0();
	}
}
