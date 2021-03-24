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
	public class QuestCellBase : GradientCell
	{
		// Fields
		[SerializeField]
		protected GameObject questStateIconRoot;
		protected GameObject questStateIconObj;
		[CompilerGenerated]
		private FlashPlayerManager _flashPlayerManager_k__BackingField;
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
	
		// Properties
		public FlashPlayerManager flashPlayerManager { [CompilerGenerated] get; [CompilerGenerated] set; }
		public SimpleAnimationCell animationCell { get; }
	
		// Constructors
		public QuestCellBase();
	
		// Methods
		public virtual void SetStateIcons();
		public override bool SetGradientShader();
		protected void CreateNewEffect(GameObject newIconRoot, GameObject newGlowRoot, Vector2 vec);
		public static void SetupNewIcon(FlashPlayerManager flashPlayerManager, QuestListCellShaderExchanger shaderExchanger, GameObject newIconRoot, Vector3 newEffectlocalPos, ref FlashPlayer flashNewIcon);
		public static FlashPlayer CreateNewIcon(FlashPlayerManager flashPlayerManager, QuestListCellShaderExchanger shaderExchanger, GameObject newIconRoot, Vector3 newEffectlocalPos);
		public static void SetupNewGlow(FlashPlayerManager flashPlayerManager, QuestListCellShaderExchanger shaderExchanger, GameObject newGlowRoot, Vector2 vec, Vector3 newEffectlocalPos, ref FlashPlayer flashNewGlow);
		public static FlashPlayer CreateNewGlow(FlashPlayerManager flashPlayerManager, QuestListCellShaderExchanger shaderExchanger, GameObject newGlowRoot, Vector3 newEffectlocalPos, Vector3 localScale);
	}
}
