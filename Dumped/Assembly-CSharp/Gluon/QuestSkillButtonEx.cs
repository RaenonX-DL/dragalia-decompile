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
	public class QuestSkillButtonEx : QuestSkillButtonBase
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		private RectTransform _rootRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _invalidRt;
		[SerializeField]
		[Tooltip]
		private RectTransform _offsetRt;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _iconImage;
		[SerializeField]
		[Tooltip]
		private SpriteRenderer _bgImage;
		[SerializeField]
		[Tooltip]
		private Button _button;
		[Header]
		[SerializeField]
		[Tooltip]
		private Vector3 _outsideInitialPos;
		[SerializeField]
		[Tooltip]
		private float _moveTime;
		[SerializeField]
		[Tooltip]
		private Ease _showMoveEase;
		[SerializeField]
		[Tooltip]
		private Ease _hideMoveEase;
		[SerializeField]
		[Tooltip]
		protected AnimData[] _iconAnimData;
		[SerializeField]
		[Tooltip]
		protected AnimData[] _bgAnimData;
		[SerializeField]
		[Tooltip]
		protected OffsetPosData _iconOffsetPosData;
		private VisibleUIObject _rootVisible;
		private VisibleUIObject _invalidVisible;
		private RectTransform _iconImageRt;
		private RectTransform _bgImageRt;
		private Tweener _twAnim;
		private Sequence _seqButtonAnim;
		private Param _param;
		private Vector3 _offsetInitialPos;
		private bool _isLeftFlag;
		private bool _isButtonValidate;
	
		// Nested types
		[Serializable]
		public class AnimData
		{
			// Fields
			[Tooltip]
			public Vector3 scale;
			[Tooltip]
			public float animTime;
			[Tooltip]
			public float afterWaitTime;
			[Tooltip]
			public Ease ease;
			[HideInInspector]
			public Vector3 prevScale;
	
			// Constructors
			public AnimData();
		}
	
		[Serializable]
		public class OffsetPosData
		{
			// Fields
			[Tooltip]
			public Vector3 offsetPos_JP;
			[Tooltip]
			public Vector3 offsetPos_EN_US;
			[Tooltip]
			public Vector3 offsetPos_ZH_CN;
			[Tooltip]
			public Vector3 offsetPos_ZH_TW;
			[Tooltip]
			public Vector3 offsetPos_EN_EU;
	
			// Constructors
			public OffsetPosData();
	
			// Methods
			public Vector3 GetOffsetPos();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass27_0
		{
			// Fields
			public Action onClick;
	
			// Constructors
			public __c__DisplayClass27_0();
	
			// Methods
			internal void _Initialize_b__0();
		}
	
		// Constructors
		public QuestSkillButtonEx();
	
		// Methods
		private void Awake();
		public static QuestSkillButtonEx Create(GameObject parent, int index, Action onClick, bool isLeft);
		public void Initialize(Action onClick, bool isLeft);
		public void OnDestroy();
		public override void FastUpdate();
		public override bool ApplyIcon(InGameEventExtendAtlasManager eeAtlasManager);
		public override void Show(bool isForce = false, bool isImmediate = false);
		public override void Hide(bool isForce = false, bool isImmediate = false);
		public override void Visible(bool b);
		public override bool IsVisible();
		public override void Validate(bool b, bool force = false);
		private void CheckInvalidObj();
		private void PlayShowAnim(bool isImmediate = false);
		private void PlayHideAnim(bool isImmediate = false);
		private void ApplyAnimData(AnimData data, RectTransform imageRt);
		private Sequence CreateButtonAnim();
		protected virtual void OnUpdateIconImageScale(Vector3 scale);
		protected virtual void OnUpdateBgImageScale(Vector3 scale);
		public override void CopyParam(Param param);
		public override void ApplyParam(Param param);
		[CompilerGenerated]
		private void _PlayShowAnim_b__37_0();
		[CompilerGenerated]
		private void _PlayHideAnim_b__38_0();
	}
}
