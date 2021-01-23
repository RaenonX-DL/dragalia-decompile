/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Dungeon
{
	public class ProximityObjectRabbit : FastUpdateMonoBehaviour
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private float SurpriseDistance;
		[SerializeField]
		[Tooltip]
		private float AwayDistance;
		[SerializeField]
		[Tooltip]
		private float WaitTimeSecond;
		[SerializeField]
		[Tooltip]
		private Transform targetTransform;
		[SerializeField]
		[Tooltip]
		private float speed;
		[SerializeField]
		[Tooltip]
		private float MoveEndTime;
		private Animator anim;
		private int hashMoveEnd;
		private int hashMoveIn;
		private int hashSurprise;
		private Vector3 initialPos;
		private Vector3 startPos;
		private Vector3 targetPos;
		private float moveWaitingTimer;
		private State state;
	
		// Nested types
		private enum State
		{
			Idle = 0,
			Surprise = 1,
			MoveAway = 2,
			MoveWaiting = 3,
			MoveReturn = 4
		}
	
		// Constructors
		public ProximityObjectRabbit();
	
		// Methods
		private void Start();
		public override void FastUpdate();
		private void StartMove(Vector3 spos, Vector3 epos);
		private void OnSurpriseDistance();
		private void OnMoveStartDistance();
		private void OnDistanceExit();
	}
}
