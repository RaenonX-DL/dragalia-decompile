/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[Serializable]
	public class UIAnimationSetting
	{
		// Fields
		public UIAnimationSettingTopMenuSetting topMenuSetting;
		public UIAnimationSettingSecondaryMenu secondaryMenuSetting;
		public UIAnimationSettingInnerMove innerMoveSetting;
		public GameObject targetObject;
		public UIAnimationClassType animationType;
	
		// Nested types
		public enum UIAnimationClassType
		{
			NotAssigned = -1,
			TopMenu_VanishingPoint = 0,
			SecondaryMenu_ParallelDirectional = 1,
			InnerMove_InOutToPhotoshopPosition = 2,
			Custom = 100000
		}
	
		[Serializable]
		public class UIAnimationSettingBase
		{
			// Constructors
			public UIAnimationSettingBase();
		}
	
		[Serializable]
		public class UIAnimationSettingTopMenuSetting : UIAnimationSettingBase
		{
			// Fields
			public bool applyShake;
			public TargetType targetType;
	
			// Nested types
			public enum TargetType
			{
				Default = 0,
				BGChara = 1
			}
	
			// Constructors
			public UIAnimationSettingTopMenuSetting(UIAnimationSettingTopMenuSetting anotherSetting);
		}
	
		[Serializable]
		public class UIAnimationSettingSecondaryMenu : UIAnimationSettingBase
		{
			// Fields
			public Vector3 enterFromDirection;
	
			// Nested types
			public enum DirectionDefine
			{
				Up = 0,
				Down = 1,
				Left = 2,
				Right = 3,
				Custom = 4
			}
	
			// Constructors
			public UIAnimationSettingSecondaryMenu(UIAnimationSettingSecondaryMenu anotherSetting);
	
			// Methods
			public void ApplyDirection(DirectionDefine direction);
			public DirectionDefine GetDirection();
		}
	
		[Serializable]
		public class UIAnimationSettingInnerMove : UIAnimationSettingBase
		{
			// Fields
			public Vector3 moveToOffset;
			public bool applyBounce;
			public bool shouldYRelativeToCanvasSize;
			public bool isAlphaFade;
			public float fadeEnterDurationOffset;
			public float fadeExitDurationOffset;
	
			// Constructors
			public UIAnimationSettingInnerMove(UIAnimationSettingInnerMove anotherSetting);
		}
	
		// Constructors
		public UIAnimationSetting(UIAnimationSetting anotherSetting, GameObject targetObject);
	}
}
