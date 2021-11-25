using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public abstract class ManaCircle2DCirclePieceBase : MonoBehaviour
	{
		public enum PieceState
		{
			None,
			Released,
			Releasable,
			NotRelease,
			NotTarget
		}

		public PieceState nowState;

		protected Transform effectBase;

		protected GrowthManaCircleModel model;

		protected Image pieceIcon;

		protected int circleIndex;

		private GameObject releasableEffectObject;

		private Button iconButton;

		public abstract void UpdatePieceState();

		protected abstract void PieceIconPressedCallBack();

		private void Awake()
		{
		}

		public void InitPiece(GrowthManaCircleModel model, int circleIndex)
		{
		}

		public void UpdatePieceIcon()
		{
		}

		public void OnPieceIconPressed()
		{
		}

		public void PlayReleaseEffect(GrowthManaCircle2DScene scene, [Optional] Action onCompleteCallBack)
		{
		}

		private void PlayReleasablePieceEffect()
		{
		}

		private void DestroyReleasablePieceEffect()
		{
		}

		public void SetEnableIconButton(bool enable)
		{
		}
	}
}
