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
	public class DefenseEventProgressMoveObjUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		protected RectTransform _rootRt;
		[SerializeField]
		protected RectTransform _iconRt;
		[SerializeField]
		protected SpriteRenderer _iconImage;
		[Header]
		[SerializeField]
		[Tooltip]
		protected float _moveCompletionThreshold;
		[SerializeField]
		[Tooltip]
		protected float _moveCompletionTime;
		protected DefenseEventProgressInfoUI _infoUI;
		protected VisibleUIObject _visible;
		protected EnemyCharacter _enemy;
		protected Sequence _seqAppear;
		protected Sequence _seqAttack;
		protected Sequence _seqDisappear;
		protected Tweener _tweenMove;
		protected Action<int> _OnDisappear;
		protected float _positionRate;
		protected float _lastPositionRate;
		[CompilerGenerated]
		private float _sortingPosZ_k__BackingField;
	
		// Properties
		public float sortingPosZ { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Nested types
		[CompilerGenerated]
		private sealed class __c__DisplayClass37_0
		{
			// Fields
			public DefenseEventProgressMoveObjUI __4__this;
			public int enemySerialId;
	
			// Constructors
			public __c__DisplayClass37_0();
	
			// Methods
			internal void _PlayDisappear_b__0();
		}
	
		// Constructors
		public DefenseEventProgressMoveObjUI();
	
		// Methods
		public virtual void Initialize(DefenseEventProgressInfoUI infoUI, Material material, Action<int> onDisappear);
		public virtual void Setup(EnemyCharacter chara, DefenseEventInfoCtrl.MoveObjIconType type);
		private void OnDestroy();
		protected virtual void Release();
		public virtual void Show();
		public virtual void Hide();
		public override void FastUpdate();
		public virtual void SetIcon(Sprite sprite);
		public virtual void SetIcon(DefenseEventInfoCtrl.MoveObjIconType type);
		public virtual void SetPosition(float rate);
		public virtual void ApplyPosition();
		public virtual bool IsEndPoint();
		public virtual void ActionAppear();
		public virtual void ActionAttack();
		public virtual void ActionDisappear();
		public virtual bool IsPlayingAction();
		protected virtual void PlayAppear();
		protected virtual void PlayAttack();
		protected virtual void PlayDisappear();
		[CompilerGenerated]
		private void _SetPosition_b__28_0(float v);
		[CompilerGenerated]
		private void _SetPosition_b__28_1();
		[CompilerGenerated]
		private void _PlayAppear_b__35_0();
		[CompilerGenerated]
		private void _PlayAttack_b__36_0();
	}
}
