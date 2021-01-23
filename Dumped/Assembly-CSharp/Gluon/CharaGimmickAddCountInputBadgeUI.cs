/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaGimmickAddCountInputBadgeUI : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private RectTransform _rootRt;
		[SerializeField]
		private RectTransform _iconRt;
		[SerializeField]
		private SpriteRenderer _iconImage;
		[SerializeField]
		private SpriteRenderer _blinkImage;
		[SerializeField]
		private VisibleUIObject _visibleRoot;
		[Header]
		[SerializeField]
		private Sprite _enableIconSprite;
		[SerializeField]
		private Sprite _disableIconOffSprite;
		private Sequence _seqShow;
		private Sequence _seqHide;
		private Sequence _seqEnable;
		private Vector3 _orgScaleIcon;
		[CompilerGenerated]
		private int _ShowAnimIndex_k__BackingField;
		[CompilerGenerated]
		private int _HideAnimIndex_k__BackingField;
		[CompilerGenerated]
		private bool _IsEnableIcon_k__BackingField;
	
		// Properties
		public int ShowAnimIndex { [CompilerGenerated] get; [CompilerGenerated] set; }
		public int HideAnimIndex { [CompilerGenerated] get; [CompilerGenerated] set; }
		public bool IsEnableIcon { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass30_0
		{
			// Fields
			public CharaGimmickAddCountInputBadgeUI __4__this;
			public Action onComplete;
	
			// Constructors
			public __c__DisplayClass30_0();
	
			// Methods
			internal void _CreateActionEnable_b__0();
		}
	
		// Constructors
		public CharaGimmickAddCountInputBadgeUI();
	
		// Methods
		public void Initialize(Transform parent);
		private void OnDestroy();
		public void Show(bool anim = true);
		public void Hide(bool anim = true);
		public void SetEnableIcon(bool enable, bool force = false, Action onComplete = null);
		private void CreateActionShow();
		private void CreateActionHide();
		private void CreateActionEnable(Action onComplete = null);
		[CompilerGenerated]
		private void _CreateActionShow_b__28_0();
		[CompilerGenerated]
		private void _CreateActionHide_b__29_0();
	}
}
