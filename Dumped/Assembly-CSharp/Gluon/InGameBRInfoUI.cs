/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class InGameBRInfoUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		private RectTransform _rootRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _weaponExpCounterRt;
		[SerializeField]
		[Tooltip]
		private InGameCounterUI _suvivorCounter;
		[SerializeField]
		[Tooltip]
		private InGameCounterUI _killCounter;
		[SerializeField]
		[Tooltip]
		private InGameCounterUI _weaponLevelCounter;
		[SerializeField]
		[Tooltip]
		private InGameCounterUI _weaponExpCounter;
		[SerializeField]
		[Tooltip]
		private InGameCounterUI _weaponExpCounter2;
		[SerializeField]
		protected InGameGaugeUISpriteRenderer _weaponGauge;
		[SerializeField]
		[Tooltip]
		protected RectTransform _weaponLevelupAnimRt;
		[SerializeField]
		[Tooltip]
		protected RectTransform _weaponGaugeAnimRt;
		[SerializeField]
		protected SpriteRenderer _weaponGaugeAnimImage;
		[SerializeField]
		protected SpriteRenderer _weaponLevelupImage;
		[Header]
		[SerializeField]
		protected float _levelupTextAnimTime;
		[SerializeField]
		protected float _levelupTextIntervalTime;
		[SerializeField]
		protected float _levelupTextPosY;
		[SerializeField]
		protected float _levelupTextPosY2;
		[SerializeField]
		protected float _levelupTextPosY3;
		[SerializeField]
		protected Vector2 _gaugeAnimScale;
		[SerializeField]
		protected Vector2 _gaugeAnimScale2;
		[SerializeField]
		protected float _gaugeAnimTime;
		[SerializeField]
		protected float _gaugeIntervalTime;
		[SerializeField]
		protected float _gaugeAnimTime2;
		protected Sequence _seqLevelup;
		protected Sequence _seqGaugeAnim;
		protected VisibleUIObject _weaponExpCounterVisible;
		private int _lastSuvivorCount;
		private int _lastKillCount;
		protected int _lastWeaponLevel;
		protected int _lastExp;
		protected int _lastNextExp;
		protected float _reqGaugeRate;
		protected bool _isDirty;
		protected bool _isLevelMax;
	
		// Constructors
		public InGameBRInfoUI();
	
		// Methods
		public static InGameBRInfoUI Create(GameObject parent, int siblingIndex = -1);
		protected virtual void Initialize();
		private void OnDestroy();
		public override void FastUpdate();
		private void SetSuvivorNum(bool isForce = false);
		private void SetSuvivorNum(int count, bool isForce = false);
		private int GetSuvivorCount();
		private void SetKillNum(bool isForce = false);
		private void SetKillNum(int count, bool isForce = false);
		private int GetKillCount();
		private void SetWeaponExp(bool isForce = false, bool isAnim = true);
		protected void ResetLevelupTextAnim();
		protected void PlayLevelupTextAnim();
		protected void PlayGaugeAnim(bool isLevelMax);
		protected void SetAlpha(ref SpriteRenderer sprite, float alpha);
		[CompilerGenerated]
		private void _PlayLevelupTextAnim_b__45_0();
		[CompilerGenerated]
		private void _PlayGaugeAnim_b__46_0();
	}
}
