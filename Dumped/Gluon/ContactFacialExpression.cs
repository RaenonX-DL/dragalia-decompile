using System.Collections;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class ContactFacialExpression : MonoBehaviour
	{
		public enum FacialAnimationType
		{
			None,
			Idle,
			Petting,
			Hate
		}

		private enum BlinkTextureIndex
		{
			Open,
			Close,
			Half,
			Damaged
		}

		private Material targetMaterial;

		private const int faceCountInRow = 4;

		private const float textureWidth = 0.125f;

		private Sequence runningSeq;

		private Coroutine runningCoroutine;

		private bool useAutoFacialControllerAnimation;

		private FacialAnimationType currentFacialAnimationType;

		private DragonFacialController facialController;

		private void Start()
		{
		}

		private void TerminateRunningSequenceAndCoroutine()
		{
		}

		public void RunIdleFacialExpression(bool isForceStartAutoBlink = false)
		{
		}

		private IEnumerator RunIdleFacialExpressionLoopCoroutine()
		{
			return null;
		}

		public void RunPettingFacialExpression()
		{
		}

		public void ResetFacialExpression()
		{
		}

		public void RunHateFacialExpression(float maxTime)
		{
		}

		private IEnumerator AutoChangeBackFromHateState(float waitTime)
		{
			return null;
		}

		private void UpdateBlinkMaterial(BlinkTextureIndex textureIndex)
		{
		}
	}
}
