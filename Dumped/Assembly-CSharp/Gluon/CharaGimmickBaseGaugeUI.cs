/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Core;
using Gluon.Master;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharaGimmickBaseGaugeUI : FastUpdateMonoBehaviour
	{
		// Constructors
		public CharaGimmickBaseGaugeUI();
	
		// Methods
		public virtual void Show();
		public virtual void Hide();
		public virtual bool IsVisible();
		public virtual void SetGaugeValue(int idx, int value, int consumeValue, int maxValue, bool isImmediateGaugeAnim = false, bool isPlayAnim = false, bool isSkipGaugePrevWaitTime = false, bool isForce = false);
		public virtual void SetGaugeAnimCompleteCallback(int idx, Action<int> onComplete);
		public virtual void SetGaugeAnimCompleteCallback(int idx, Action<int, int, int> onComplete);
		public virtual void SetAbilityData(ref List<AbilityDataElement> list);
		public virtual void ChangeAppearance(int type, bool isForce = false);
		public virtual int GetGaugeType();
		public virtual float GetGaugeMoveTime();
		public static int CompareAbilityDataElementByConditionValue(AbilityDataElement x, AbilityDataElement y);
	}
}
