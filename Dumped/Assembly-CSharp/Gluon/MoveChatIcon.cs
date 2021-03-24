/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Dungeon;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[Serializable]
	internal class MoveChatIcon
	{
		// Fields
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
	
		// Nested types
		private enum eDirection
		{
			None = 0,
			Down = 1,
			Up = 2,
			Left = 3,
			Right = 4,
			Max = 5
		}
	
		private struct CollisionAreaHitData
		{
			// Fields
			public eDirection dir;
			public RectTransform trans;
			public int colliderIndex;
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass25_0
		{
			// Fields
			public RectTransform collide;
	
			// Constructors
			public __c__DisplayClass25_0();
	
			// Methods
			internal bool _JudgeAdsorption_b__0(CollisionAreaHitData x);
		}
	
		[CompilerGenerated]
		private sealed class __c__DisplayClass28_0
		{
			// Fields
			public eDirection dir;
	
			// Constructors
			public __c__DisplayClass28_0();
	
			// Methods
			internal bool _UpdatePlayerRect_b__0(CollisionAreaHitData x);
		}
	
		// Constructors
		public MoveChatIcon();
	
		// Methods
		public void Initialize(RectTransform[] rects, StampCollisionArea[] collAreas, RectTransform trans);
		public void InitializeOnDisplay(CharacterBase targetCharacter);
		public void Update(CharacterBase targetCharacter);
		private void UpdateMove(CharacterBase targetCharacter, Vector2 targetPos);
		private Vector3 CalcTargetCanvasPosition(CharacterBase targetCharacter, out bool isError);
		private Vector3 CalcPlayerCanvasPosition(CharacterBase targetCharacter, out bool isError);
		private Vector3 CalcLimitedCanvasPosition(Vector3 position3d, float offsetY, out bool isError);
		private Vector2 ToCenterPos(eDirection dir, Vector2 pos);
		private Vector2 ToPivotBasePos(eDirection dir, Vector2 centerPos);
		private void SetPivot(eDirection dir);
		private Bounds CreateDirectionalBounds(eDirection dir, Vector2 nextCenterPos);
		private bool JudgeAdsorption(eDirection dir, Bounds dirBounds, int colliderIndex, bool isExcludeArrowSize, ref Vector2 nextCenterPos, List<CollisionAreaHitData> rectList);
		private bool UpdateAdsorption(eDirection dir, bool isExcludeArrowSize, ref Vector2 nextCenterPos, List<CollisionAreaHitData> rectList);
		private bool UpdateAdsorptionSpecific(eDirection dir, bool isExcludeArrowSize, ref Vector2 nextCenterPos, List<CollisionAreaHitData> rectList, int colliderIndex);
		private void UpdatePlayerRect(Vector3 targetPos, Vector3 playerCenter);
	}
}
