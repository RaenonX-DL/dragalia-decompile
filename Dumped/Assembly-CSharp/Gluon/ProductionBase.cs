/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class ProductionBase
	{
		// Fields
		protected CharacterManager charaManager;
		protected CameraController cameraController;
		protected InGameUICtrl uiCtrl;
		protected float time;
		protected float enableSkipTime;
		[CompilerGenerated]
		private bool _skip_k__BackingField;
	
		// Properties
		public bool skip { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public ProductionBase();
	
		// Methods
		protected void SetEnableSkipTime(float t);
		public virtual bool Update();
		public static void ChangeAttachWeaponForKAT(CharacterBase chara, string state, float frameStart = 0f, float frameEnd = 0f, bool forceLeft = false);
	}
}
