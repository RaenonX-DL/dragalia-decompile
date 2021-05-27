/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaGimmickBaseInputUI : FastUpdateMonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		[Tooltip]
		protected RectTransform _adjustRt;
		[Header]
		[SerializeField]
		[Tooltip]
		protected float _humanAdjustPosY;
		[SerializeField]
		[Tooltip]
		protected float _dragonAdjustPosY;
		public const float FRAME_2_SECOND = 0.033333335f;
	
		// Constructors
		public CharaGimmickBaseInputUI();
	
		// Methods
		public virtual void Show(int num);
		public virtual void Hide(bool anim = true);
		public virtual bool IsVisible();
		public virtual void ReserveItem(int actionId);
		public virtual void SetCount(int num, bool force = false, bool immediate = false);
		public virtual int GetInputType();
		public virtual int GetStepNum();
	}
}
