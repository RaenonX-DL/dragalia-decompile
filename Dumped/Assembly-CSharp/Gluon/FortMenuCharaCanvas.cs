/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FortMenuCharaCanvas : AnimationUICanvas
	{
		// Fields
		public FortMenuScene scene;
		public OutGameBgChara bgCharacter;
	
		// Constructors
		public FortMenuCharaCanvas();
	
		// Methods
		private void Start();
		public void OnCharaPressed();
		public void Talk(string voiceGroupName, string voiceName);
	}
}
