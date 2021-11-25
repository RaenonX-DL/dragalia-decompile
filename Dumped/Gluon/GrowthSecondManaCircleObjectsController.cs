using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace Gluon
{
	public class GrowthSecondManaCircleObjectsController : GrowthManaCircleObjectsController
	{
		public GameObject[] SprialEffectObjBase;

		public Vector3[] pointNodesPos;

		public GameObject godRayObjBase;

		public GrowthSecondManaCircleManaPieceObject[] points;

		public float totalCircleRotation;

		public Vector3[] piecePos;

		public bool isPlayAutoReleaseEffect;

		protected GrowthSecondManaCircleModel secondModel;

		protected GrowthSecondManaCircleScene secondScene;

		private GameObject[] pointNodes;

		private GameObject[] pointObjects;

		private const int roundPieceCount = 10;

		private const float baseMoveupRate = 2.5f;

		private List<int> billboardPieceIds;

		private GrowthManaCircleEffectSettings efs;

		private bool isEndPieceCameraAngle;

		private bool isPlayEndPieceCameraMove;

		public const int numOfPoints = 20;

		public override void Init()
		{
		}

		protected override IEnumerator LoadMotifEffect()
		{
			return null;
		}

		public EffectObject CreateFirstSymbolObject()
		{
			return null;
		}

		public void CreateCircleObject()
		{
		}

		private void AddBoxColliderToPieceObject(int index)
		{
		}

		private void SetupPiecePointNodes(int setupCount)
		{
		}

		public override void RotateCircle(float value)
		{
		}

		public override int GetCenterTouchPointIndex()
		{
			return default(int);
		}

		public override void LateUpdateCircle()
		{
		}

		public void SetTouchablePoints(int centerIndex)
		{
		}

		public void UpdetePieceAngle()
		{
		}

		public override void UpdateCircleRotation()
		{
		}

		private void StartAdjustAnimation()
		{
		}

		private void PlaySprialAnimating(float rotate)
		{
		}

		public void SetSprialRotation(float rotate)
		{
		}

		private void AdjustAnimationComplete()
		{
		}

		public override bool ShouldPointDescDraw()
		{
			return default(bool);
		}

		public bool IsReleasePiece(int pieceIndex)
		{
			return default(bool);
		}

		public void MovePointToFront(int index, float duration = 0.8f)
		{
		}

		public void PlayAutoReleaseMoveAnimation(int lastIndex, float duration, Ease ease)
		{
		}

		public void PlayReleasePointEffect(GrowthSecondManaCircleManaPieceObject touchPoint)
		{
		}

		private IEnumerator ChangeReleasePointCoroutine(EffectObject effectObject, bool isLastPiece)
		{
			return null;
		}

		public void PlayFirstEnterSprialEffectAsync()
		{
		}

		public void PlaySymbolEffectAsync()
		{
		}

		public void ResetSprialEffect()
		{
		}

		public void PlayFirstEnterEffectAsync()
		{
		}

		private void DoFirstEnterEffectCameraRotate()
		{
		}

		private Vector3 GetBezierCurvePos(float t)
		{
			return default(Vector3);
		}

		private void SetEndPieceCameraAngle()
		{
		}

		public override void Reset()
		{
		}

		public override int GetNumOfUnReleasedPointOnCurrentMaxCircle()
		{
			return default(int);
		}

		public void PlayReleaseAutoSkipEffect(List<GrowthSecondManaCircleManaPieceObject> pointList, int effectStartPieceCount, int effectEndPieceCount)
		{
		}

		public void PlayReleaseAutoEffect(List<GrowthSecondManaCircleManaPieceObject> pointList)
		{
		}

		private void AutoReleaseEffectCoroutine(GrowthSecondManaCircleManaPieceObject touchPoint, float delay, bool isSoundOff)
		{
		}
	}
}
