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
	public class DefenseEventProgressInfoUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		protected RectTransform _rootRt;
		[SerializeField]
		protected RectTransform _fortRt;
		[SerializeField]
		protected RectTransform[] _glitterRt;
		[SerializeField]
		protected RectTransform _moveObjRt;
		[SerializeField]
		protected RectTransform _lineStartRt;
		[SerializeField]
		protected RectTransform _lineEndRt;
		[SerializeField]
		protected RectTransform _gaugeRt;
		[SerializeField]
		protected SpriteRenderer _fortImage;
		[SerializeField]
		protected SpriteRenderer _fortImageAdd;
		[SerializeField]
		protected SpriteRenderer _lineImage;
		[SerializeField]
		protected SpriteRenderer _gaugeBgImage;
		[SerializeField]
		protected SpriteRenderer[] _glitterImage;
		[SerializeField]
		protected SpriteRenderer[] _glitterImageAdd;
		[SerializeField]
		protected InGameGaugeUISpriteRenderer _gaugeUI;
		[SerializeField]
		protected DefenseEventLineMsgUI _lineMsg;
		[Header]
		[SerializeField]
		protected DefenseEventProgressMoveObjUI _originMoveObj;
		[SerializeField]
		protected Sprite _sprFort;
		[SerializeField]
		protected Sprite _sprFortAdd;
		[SerializeField]
		protected Sprite _sprLine;
		[SerializeField]
		protected Sprite _sprGaugeBg;
		[SerializeField]
		protected Sprite _sprGlitter;
		[SerializeField]
		protected Sprite[] _spriteIconList;
		[SerializeField]
		protected Sprite _sprMsg;
		[SerializeField]
		protected Material _matSprite;
		[SerializeField]
		protected Material _matAddSprite;
		[SerializeField]
		protected Material _matDOTween;
		[Header]
		[SerializeField]
		[Tooltip]
		protected Vector2 _glitterScale;
		[SerializeField]
		[Tooltip]
		protected Vector2 _glitterStartDelayTime;
		[SerializeField]
		[Tooltip]
		protected Vector2 _glitterCorrectRadius;
		[SerializeField]
		[Tooltip]
		protected float _fortDamageMsgIntervalTime;
		[SerializeField]
		[Tooltip]
		protected float _fortDyingMsgHpRate;
		protected InGameFollowLayout _followLayout;
		protected Sequence _seqFortDamage;
		protected Sequence[] _seqFortDamageGritter;
		protected TweenUtil.ColorModulusArgs _colorModulusFort;
		protected float _fortDamageMsgIntervalCount;
		protected bool _isFortDyingMsgDisplayed;
		private const float GlitterDefaultScale = 100f;
	
		// Properties
		public RectTransform moveObjRt { get; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_0
		{
			// Fields
			public Sequence seq;
	
			// Constructors
			public __c__DisplayClass54_0();
	
			// Methods
			internal void _PlayFortDamage_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass54_1
		{
			// Fields
			public Sequence seq;
	
			// Constructors
			public __c__DisplayClass54_1();
	
			// Methods
			internal void _PlayFortDamage_b__1();
		}
	
		// Constructors
		public DefenseEventProgressInfoUI();
	
		// Methods
		public static DefenseEventProgressInfoUI Create(GameObject parent, InGameUIConst.DecorationType type, int siblingIndex = -1);
		public virtual void Initialize(InGameUIConst.DecorationType type);
		private void OnDestroy();
		protected virtual void Release();
		public override void FastUpdate();
		public virtual void Show();
		public virtual void Hide();
		protected virtual void Visible(bool b, bool force = false);
		public virtual void SetFortHpRate(float rate, bool immediate);
		public virtual Sprite GetIconSprite(DefenseEventInfoCtrl.MoveObjIconType type);
		public virtual DefenseEventProgressMoveObjUI CreateMoveObj(Action<int> onDisappear);
		public virtual DefenseEventLineMsgUI GetLineMsg(GameObject parent);
		public virtual Vector3 GetMoveObjPosition(float rate);
		public virtual void ActionFortDamage();
		protected virtual void PlayFortDamage();
	}
}
