/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaGimmickBaseInputUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		protected RectTransform _rootRt;
		[Header]
		[SerializeField]
		[Tooltip]
		protected float _humanAdjust3DPosY;
		[SerializeField]
		[Tooltip]
		protected float _dragonAdjust3DPosY;
		protected float moveTime;
		protected Vector2 moveSposS;
		protected Vector2 moveSposE;
		protected Vector2 prevSpos;
		public const float MOVE_UPDATE_DURATION_TIME = 0.16666667f;
		public const float FRAME_2_SECOND = 0.033333335f;
	
		// Constructors
		public CharaGimmickBaseInputUI();
	
		// Methods
		public virtual void Show(CharacterBase owner, int num, int max);
		public virtual void Hide(bool anim = true);
		public virtual bool IsVisible();
		public virtual void ReserveItem(CharacterBase owner);
		public virtual void SetCount(int num, bool force = false, bool immediate = false);
		public virtual int GetInputType();
		public virtual int GetStepNum();
		protected void UpdatePosition(CharacterBase chara, bool force = false);
		protected Vector2 GetEasePos(Vector2 startPos, Vector2 endPos, float time, float duration);
		protected Vector2 GetScreenPos(CharacterBase chara);
	}
}
