using System;
using System.Collections.Generic;
using Gluon.Dungeon;
using UnityEngine;

namespace Gluon
{
	[Serializable]
	internal class MoveChatIcon
	{
		private enum eDirection
		{
			None,
			Down,
			Up,
			Left,
			Right,
			Max
		}

		private struct CollisionAreaHitData
		{
			public eDirection dir;

			public RectTransform trans;

			public int colliderIndex;
		}

		[SerializeField]
		private RectTransform targetArrowParent;

		[SerializeField]
		private RectTransform targetArrowIcon;

		[SerializeField]
		private RectTransform playerNo;

		[SerializeField]
		private float moveSpeed;

		private eDirection currentDir;

		private RectTransform targetTransform;

		private RectTransform[] boxColliders;

		private StampCollisionArea[] collisionAreas;

		private Vector2 arrowCollisionSizeH;

		private Vector2 arrowCollisionSizeV;

		private const int CollisionAreaHitDataNum = 2;

		private List<CollisionAreaHitData> intersectRectList;

		public void Initialize(RectTransform[] rects, StampCollisionArea[] collAreas, RectTransform trans)
		{
		}

		public void InitializeOnDisplay(CharacterBase targetCharacter)
		{
		}

		public void Update(CharacterBase targetCharacter)
		{
		}

		private void UpdateMove(CharacterBase targetCharacter, Vector2 targetPos)
		{
		}

		private Vector3 CalcTargetCanvasPosition(CharacterBase targetCharacter, out bool isError)
		{
			return default(Vector3);
		}

		private Vector3 CalcPlayerCanvasPosition(CharacterBase targetCharacter, out bool isError)
		{
			return default(Vector3);
		}

		private Vector3 CalcLimitedCanvasPosition(Vector3 position3d, float offsetY, out bool isError)
		{
			return default(Vector3);
		}

		private Vector2 ToCenterPos(eDirection dir, Vector2 pos)
		{
			return default(Vector2);
		}

		private Vector2 ToPivotBasePos(eDirection dir, Vector2 centerPos)
		{
			return default(Vector2);
		}

		private void SetPivot(eDirection dir)
		{
		}

		private Bounds CreateDirectionalBounds(eDirection dir, Vector2 nextCenterPos)
		{
			return default(Bounds);
		}

		private bool JudgeAdsorption(eDirection dir, Bounds dirBounds, int colliderIndex, bool isExcludeArrowSize, ref Vector2 nextCenterPos, List<CollisionAreaHitData> rectList)
		{
			return default(bool);
		}

		private bool UpdateAdsorption(eDirection dir, bool isExcludeArrowSize, ref Vector2 nextCenterPos, List<CollisionAreaHitData> rectList)
		{
			return default(bool);
		}

		private bool UpdateAdsorptionSpecific(eDirection dir, bool isExcludeArrowSize, ref Vector2 nextCenterPos, List<CollisionAreaHitData> rectList, int colliderIndex)
		{
			return default(bool);
		}

		private void UpdatePlayerRect(Vector3 targetPos, Vector3 playerCenter)
		{
		}
	}
}
