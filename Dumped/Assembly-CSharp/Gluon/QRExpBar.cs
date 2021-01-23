/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class QRExpBar : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public Slider slider;
		public UnityEngine.UI.Text levelText;
		public UnityEngine.UI.Text remainText;
		[SerializeField]
		private UnityEngine.UI.Text maxLevelWarningText;
		[SerializeField]
		private GameObject nextObj;
		[SerializeField]
		private float fullGaugeSpeed;
		[SerializeField]
		public QuestUtil.Easeing ease;
		public bool bShouldPauseAtLastLevelup;
		[HideInInspector]
		public Action<int> onLevelup;
		[HideInInspector]
		public Action<int> onLastLevelup;
		[HideInInspector]
		public Action onFinished;
		[HideInInspector]
		public Func<bool> skipChecker;
		private string remainTextTemplate;
		private string levelTextTemplate;
		private GiftType giftType;
		private float waitTimeWhenLevelup;
		private bool pausedAtLastLevelup;
		private float currentValue;
		private int toValue;
		private float fromValue;
		private int toLevel;
		private int minValue;
		private int maxValue;
		private int currentLevel;
		private bool animationStarted;
		private float levelUpWaitingTimer;
		private float progressTime;
		private int maxLevel;
		private Localize.TextId maxLevelText;
	
		// Constructors
		public QRExpBar();
	
		// Methods
		public void SetValues(GiftType giftType, int beforeExp, int afterExp);
		public void SetMaxLevel(int max, Localize.TextId textId);
		public bool IsPlayBarAnimation();
		private void RefreshToGoData();
		private void RefreshView();
		public void SetLevelupWait(float duration);
		public void SetTextTemplates(string remainTemplate, string levelTemplate);
		public void StartAnimation();
		public void SkipAnimation();
		public void Update();
		private void Proceed();
		private void AnimationDone();
		public void ResumeAtLastLevelup();
	}
}
