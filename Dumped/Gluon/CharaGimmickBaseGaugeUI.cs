using System;
using System.Collections.Generic;
using Cute.Core;
using Gluon.Master;

namespace Gluon
{
	public class CharaGimmickBaseGaugeUI : FastUpdateMonoBehaviour
	{
		public virtual void Show()
		{
		}

		public virtual void Hide()
		{
		}

		public virtual bool IsVisible()
		{
			return default(bool);
		}

		public virtual void SetGaugeValue(int idx, int value, int consumeValue, int maxValue, bool isImmediateGaugeAnim = false, bool isPlayAnim = false, bool isSkipGaugePrevWaitTime = false, bool isForce = false)
		{
		}

		public virtual void SetGaugeAnimCompleteCallback(int idx, Action<int> onComplete)
		{
		}

		public virtual void SetGaugeAnimCompleteCallback(int idx, Action<int, int, int> onComplete)
		{
		}

		public virtual void SetAbilityData(ref List<AbilityDataElement> list)
		{
		}

		public virtual void ChangeAppearance(int type, bool isForce = false)
		{
		}

		public virtual int GetGaugeType()
		{
			return default(int);
		}

		public virtual float GetGaugeMoveTime()
		{
			return default(float);
		}

		public static int CompareAbilityDataElementByConditionValue(AbilityDataElement x, AbilityDataElement y)
		{
			return default(int);
		}
	}
}
