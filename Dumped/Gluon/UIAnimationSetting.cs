using System;
using UnityEngine;

namespace Gluon
{
	[Serializable]
	public class UIAnimationSetting
	{
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
		}

		[Serializable]
		public class UIAnimationSettingTopMenuSetting : UIAnimationSettingBase
		{
			public enum TargetType
			{
				Default,
				BGChara
			}

			public bool applyShake;

			public TargetType targetType;

			public UIAnimationSettingTopMenuSetting(UIAnimationSettingTopMenuSetting anotherSetting)
			{
			}
		}

		[Serializable]
		public class UIAnimationSettingSecondaryMenu : UIAnimationSettingBase
		{
			public enum DirectionDefine
			{
				Up,
				Down,
				Left,
				Right,
				Custom
			}

			public Vector3 enterFromDirection;

			public void ApplyDirection(DirectionDefine direction)
			{
			}

			public DirectionDefine GetDirection()
			{
				return default(DirectionDefine);
			}

			public UIAnimationSettingSecondaryMenu(UIAnimationSettingSecondaryMenu anotherSetting)
			{
			}
		}

		[Serializable]
		public class UIAnimationSettingInnerMove : UIAnimationSettingBase
		{
			public Vector3 moveToOffset;

			public bool applyBounce;

			public bool shouldYRelativeToCanvasSize;

			public bool isAlphaFade;

			public float fadeEnterDurationOffset;

			public float fadeExitDurationOffset;

			public UIAnimationSettingInnerMove(UIAnimationSettingInnerMove anotherSetting)
			{
			}
		}

		public UIAnimationSettingTopMenuSetting topMenuSetting;

		public UIAnimationSettingSecondaryMenu secondaryMenuSetting;

		public UIAnimationSettingInnerMove innerMoveSetting;

		public GameObject targetObject;

		public UIAnimationClassType animationType;

		public UIAnimationSetting(UIAnimationSetting anotherSetting, GameObject targetObject)
		{
		}
	}
}
