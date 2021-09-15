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
	public class QuestSkillButtonBase : FastUpdateMonoBehaviour
	{
		// Nested types
		public class Param
		{
			// Fields
			public int enableCount;
			public bool isUnlimited;
			public bool isDisplay;
			public bool isValidate;
			public int lastIconIndex;
			public float lastIconRate;
			public float targetIconRateManual;
			public bool isIconRateManual;
			public bool isReadyAnim;
			public bool isChangeAnim;
	
			// Constructors
			public Param();
	
			// Methods
			public void Reset();
			public void CopyTo(Param param);
		}
	
		// Constructors
		public QuestSkillButtonBase();
	
		// Methods
		public virtual void Show(bool isForce = false, bool isImmediate = false);
		public virtual void Hide(bool isForce = false, bool isImmediate = false);
		public virtual bool ApplyIcon();
		public virtual bool ApplyIcon(InGameEventExtendAtlasManager eeAtlasManager);
		public virtual bool ChangeIcon(int index, bool isForce, bool isFlashAnim = true);
		public virtual void SetIconRateManual(float rate, bool isForce = false);
		public virtual void Visible(bool b);
		public virtual bool IsVisible();
		public virtual void Validate(bool b, bool force = false);
		public virtual int GetCount();
		public virtual void SetCount(int n);
		public virtual void SetUnlimited();
		public virtual void SetReadyAnim();
		public virtual bool IsReadyAnim();
		public virtual void SetupReadyAnim(Material frameMat);
		public virtual void SetVisibleReadyAnim(bool b);
		public virtual bool IsActiveReadyAnim();
		public virtual void OnUpdateReadyAnimFlash(float value);
		public virtual void SetChangeAnim();
		public virtual bool IsChangeAnim();
		public virtual void CopyParam(Param param);
		public virtual void ApplyParam(Param param);
	}
}
