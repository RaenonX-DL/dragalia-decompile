/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public abstract class ManaCircle2DCirclePieceBase : MonoBehaviour
	{
		// Fields
		public PieceState nowState;
		protected Transform effectBase;
		protected GrowthManaCircleModel model;
		protected Image pieceIcon;
		protected int circleIndex;
		private GameObject releasableEffectObject;
		private Button iconButton;
	
		// Nested types
		public enum PieceState
		{
			None = 0,
			Released = 1,
			Releasable = 2,
			NotRelease = 3,
			NotTarget = 4
		}
	
		[CompilerGenerated]
		private struct _PlayReleaseEffect_d__14 : IAsyncStateMachine
		{
			// Fields
			public int __1__state;
			public AsyncVoidMethodBuilder __t__builder;
			public ManaCircle2DCirclePieceBase __4__this;
			public GrowthManaCircle2DScene scene;
			public Action onCompleteCallBack;
			private UniTask.Awaiter __u__1;
	
			// Methods
			private void MoveNext();
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine);
		}
	
		// Constructors
		protected ManaCircle2DCirclePieceBase();
	
		// Methods
		public abstract void UpdatePieceState();
		protected abstract void PieceIconPressedCallBack();
		private void Awake();
		public void InitPiece(GrowthManaCircleModel model, int circleIndex);
		public void UpdatePieceIcon();
		public void OnPieceIconPressed();
		public async void PlayReleaseEffect(GrowthManaCircle2DScene scene, Action onCompleteCallBack = null);
		private void PlayReleasablePieceEffect();
		private void DestroyReleasablePieceEffect();
		public void SetEnableIconButton(bool enable);
	}
}
