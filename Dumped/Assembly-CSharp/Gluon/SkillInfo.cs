/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using DG.Tweening;
using DG.Tweening.Core;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class SkillInfo : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private Button _button;
		[SerializeField]
		private RectTransform _offsetRt;
		[SerializeField]
		private RectTransform _effectRt;
		[SerializeField]
		private RectTransform _invalidRt;
		[SerializeField]
		private RectTransform _shadowRt;
		[SerializeField]
		private RectTransform _frameRt;
		[SerializeField]
		private RectTransform _chainSkillFrameRt;
		[SerializeField]
		private SpriteRenderer _skillIcon;
		[SerializeField]
		private SpriteRenderer _effectImage;
		[SerializeField]
		private SpriteRenderer _noUseImage;
		[SerializeField]
		private SpriteRenderer _chainSkillFrameImage;
		[SerializeField]
		private SkillIconCtrl _skillIconCtrl;
		[SerializeField]
		private InGameCounterUI _counterUI;
		[Header]
		[SerializeField]
		private float _expansionTime;
		[SerializeField]
		[Tooltip]
		private float _maxGaugeAnimTime;
		[Range]
		[SerializeField]
		[Tooltip]
		private float _maxGaugeAnimFlashPower;
		[SerializeField]
		[Tooltip]
		private float _chainSkillAnimTime;
		[CompilerGenerated]
		private int _index_k__BackingField;
		private RectTransform _rootRt;
		private Tweener _tweenerExpansion;
		private VisibleUIObject _frameVisible;
		private VisibleUIObject _shadowVisible;
		private VisibleUIObject _effectVisible;
		private VisibleUIObject _invalidVisible;
		private VisibleUIObject _chainSkillVisible;
		private float _gaugeValue;
		private float _lastGaugeValue;
		private bool _validate;
		private bool _expansionEffect;
		private bool _maxEffect;
		private bool _gaugeMax;
		private int _spGaugeCount;
		private bool _disableSkillByRequiredBuff;
		private Dictionary<int, AbnormalStatusType> _lastAbnormalStatusTypeDic;
		private bool _lastBind;
		private Vector3 _localPositionShadow;
		private Vector3 _localPositionFrame;
		private Vector3 _localPositionEffect;
		private Vector3 _localPositionNoUseImage;
		private bool _disableUpdate;
		private bool _isCheckActive;
		private int _lastSkillId;
		private string _lastIconName;
		private const float TweenerExpansionEndValue = 1f;
		private const int EmptyItemSkillID = -1;
	
		// Properties
		[HideInInspector]
		public int index { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		public delegate void ButtonDelegate(SkillInfo sender);
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass49_0
		{
			// Fields
			public ButtonDelegate func;
			public SkillInfo __4__this;
	
			// Constructors
			public __c__DisplayClass49_0();
	
			// Methods
			internal void _Initialize_b__0();
		}
	
		[Serializable]
		[CompilerGenerated]
		private sealed class __c
		{
			// Fields
			public static readonly __c __9;
			public static DOSetter<float> __9__70_0;
			public static DOSetter<float> __9__74_0;
	
			// Constructors
			static __c();
			public __c();
	
			// Methods
			internal void _CreateGaugeMaxAnim_b__70_0(float t);
			internal void _CreateChainSkillAnim_b__74_0(float t);
		}
	
		// Constructors
		public SkillInfo();
	
		// Methods
		public void Initialize(ButtonDelegate func, int idx, bool isLeft);
		public override void FastUpdate();
		private void LateUpdate();
		public bool SetSkillIcon(CharacterBase chara, int skillId);
		public bool SetEmptyItemSkillIcon(bool disableUpdate = true);
		private void SetSkillIcon(string iconName, Material material, Sprite sprite);
		public void SetItemSkillCount(int count);
		public void SetUIParent(int index);
		public void SetGaugeValue(float rate, bool force = false);
		private void CheckInactive(bool bmax);
		public void Attach(RectTransform parentRT);
		public void Visible(bool b, bool force = false);
		public bool IsVisible();
		public void Validate(bool b);
		public Vector2 GetButtonPosition();
		public Vector2 GetButtonSize();
		private void StartExpansionEffect();
		private void OnUpdateExpansion(float value);
		private void OnCompleteExpansion();
		public void PauseMaxEffect();
		public void SetEnabled(bool b);
		public Tweener CreateGaugeMaxAnim();
		public void OnUpdateGaugeMax(float value);
		public void SetupChainSkill(Texture gradationTex, Material frameMat);
		public void SetVisibleChainSkill(bool b);
		public Tweener CreateChainSkillAnim();
		public void OnUpdateChainSkill(float value);
		public void SetDisableSkillByRequiredBuff(bool v, int spGaugeCount);
	}
}
