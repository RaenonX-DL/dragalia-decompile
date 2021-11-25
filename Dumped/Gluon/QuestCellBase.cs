using System.Runtime.CompilerServices;
using UnityEngine;

namespace Gluon
{
	public class QuestCellBase : GradientCell
	{
		[SerializeField]
		protected GameObject questStateIconRoot;

		protected GameObject questStateIconObj;

		protected FlashPlayer flashNewIcon;

		protected FlashPlayer flashNewGlow;

		[SerializeField]
		protected Vector3 newEffectlocalPos;

		protected const int flashNewIconDefaultSortingOrder = 81;

		protected const int flashNewGlowDefaultSortingOrder = 76;

		protected const int flashNewEffectLoopMotionIndex = 1;

		protected const float baseNewGlowHeight = 152f;

		protected const float baseNewGlowWidth = 564f;

		private SimpleAnimationCell _animationCell;

		public FlashPlayerManager flashPlayerManager
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public SimpleAnimationCell animationCell => null;

		public virtual void SetStateIcons()
		{
		}

		public override bool SetGradientShader()
		{
			return default(bool);
		}

		protected void CreateNewEffect(GameObject newIconRoot, GameObject newGlowRoot, Vector2 vec)
		{
		}

		public static void SetupNewIcon(FlashPlayerManager flashPlayerManager, QuestListCellShaderExchanger shaderExchanger, GameObject newIconRoot, Vector3 newEffectlocalPos, ref FlashPlayer flashNewIcon)
		{
		}

		public static FlashPlayer CreateNewIcon(FlashPlayerManager flashPlayerManager, QuestListCellShaderExchanger shaderExchanger, GameObject newIconRoot, Vector3 newEffectlocalPos)
		{
			return null;
		}

		public static void SetupNewGlow(FlashPlayerManager flashPlayerManager, QuestListCellShaderExchanger shaderExchanger, GameObject newGlowRoot, Vector2 vec, Vector3 newEffectlocalPos, ref FlashPlayer flashNewGlow)
		{
		}

		public static FlashPlayer CreateNewGlow(FlashPlayerManager flashPlayerManager, QuestListCellShaderExchanger shaderExchanger, GameObject newGlowRoot, Vector3 newEffectlocalPos, Vector3 localScale)
		{
			return null;
		}
	}
}
