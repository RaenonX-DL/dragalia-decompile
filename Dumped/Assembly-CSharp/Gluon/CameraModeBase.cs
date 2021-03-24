/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CameraModeBase
	{
		// Fields
		protected int cameraStep;
		protected float cameraTime;
		[CompilerGenerated]
		private CameraController _camera_k__BackingField;
	
		// Properties
		protected CameraController camera { [CompilerGenerated] get; [CompilerGenerated] private set; }
	
		// Constructors
		public CameraModeBase(CameraController controller);
	
		// Methods
		public void Initialize();
		public virtual void Update();
	}
}
