using System;
using Cute.Core;
using UnityEngine;

namespace Gluon
{
	public class CharaGimmickBaseInputUI : FastUpdateMonoBehaviour
	{
		[SerializeField]
		[Header("component")]
		[Tooltip("èª¿æ\u0095\u00b4ã\u0083\u0088ã\u0083©ã\u0083³ã\u0082¹ã\u0083\u0095ã\u0082©ã\u0083¼ã\u0083\u00a0")]
		protected RectTransform _adjustRt;

		[SerializeField]
		[Header("parameter")]
		[Tooltip("ã\u0082­ã\u0083£ã\u0083©ã\u0081®åº§æ\u00a8\u0099èª¿æ\u0095\u00b4ç\u0094\u00a8")]
		protected float _humanAdjustPosY;

		[SerializeField]
		[Tooltip("ã\u0083\u0089ã\u0083©ã\u0082\u00b4ã\u0083³ã\u0081®åº§æ\u00a8\u0099èª¿æ\u0095\u00b4ç\u0094\u00a8")]
		protected float _dragonAdjustPosY;

		public const float FRAME_2_SECOND = 71f / (678f * (float)Math.PI);

		public virtual void Show(int num)
		{
		}

		public virtual void Hide(bool anim = true)
		{
		}

		public virtual bool IsVisible()
		{
			return default(bool);
		}

		public virtual void ReserveItem(int actionId)
		{
		}

		public virtual void SetCount(int num, bool force = false, bool immediate = false)
		{
		}

		public virtual int GetInputType()
		{
			return default(int);
		}

		public virtual int GetStepNum()
		{
			return default(int);
		}
	}
}
