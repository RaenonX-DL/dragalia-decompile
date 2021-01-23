/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaGimmickAddCountInputUI : CharaGimmickBaseInputUI
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform _fingerRt;
		[SerializeField]
		private RectTransform _fingerBgRt;
		[SerializeField]
		private RectTransform _badgeRootRt;
		[SerializeField]
		private SpriteRenderer _bgImage;
		[SerializeField]
		private CharaGimmickAddCountInputBadgeUI _baseBadge;
		[Header]
		[SerializeField]
		private float _baseBgWidth;
		[SerializeField]
		private float _addBgWidth;
		private List<CharaGimmickAddCountInputBadgeUI> _badgeList;
		private VisibleUIObject _visibleRoot;
		private Sequence _seqShow;
		private Sequence _seqHide;
		private Sequence _seqFinger;
		private CharacterBase _owner;
		private int _showBadgeNum;
		private int _maxBadgeNum;
		private bool _show;
		public const int DEFAULT_BADGE_NUM = 6;
		public const float HIDE_ANIM_ENABLE_ICON_BLINK_TIME = 0.23333335f;
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass29_0
		{
			// Fields
			public Vector2 size;
			public CharaGimmickAddCountInputUI __4__this;
	
			// Constructors
			public __c__DisplayClass29_0();
	
			// Methods
			internal void _CreateActionShow_b__1(float t);
			internal void _CreateActionShow_b__0();
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public Vector2 size;
			public CharaGimmickAddCountInputUI __4__this;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal void _CreateActionHide_b__1(float t);
			internal void _CreateActionHide_b__0();
		}
	
		// Constructors
		public CharaGimmickAddCountInputUI();
	
		// Methods
		public static CharaGimmickAddCountInputUI Create(GameObject parent, int siblingIndex = -1);
		private void Initialize();
		private void OnDestroy();
		public override void FastUpdate();
		public override void Show(CharacterBase owner, int num, int max);
		public override void Hide(bool anim = true);
		public override void ReserveItem(CharacterBase owner);
		private void ReserveItem(int num);
		private void EnableItem(int num);
		public override void SetCount(int num, bool force = false, bool immediate = false);
		public void OnEnableBadgeMaximum();
		private void CreateActionShow();
		private void CreateActionHide();
		private void CreateActionFinger();
		public override int GetInputType();
		[CompilerGenerated]
		private void _CreateActionFinger_b__31_0();
	}
}
