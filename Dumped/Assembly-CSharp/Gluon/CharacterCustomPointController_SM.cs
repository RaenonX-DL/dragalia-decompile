/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class CharacterCustomPointController_SM : CharacterCustomPointController
	{
		// Fields
		private int lastCP;
		private int lastShikigamiBulletNum;
		private bool isDirtyCP;
	
		// Constructors
		public CharacterCustomPointController_SM();
	
		// Methods
		protected override void Initialize(CharacterBase owner, params AbilityDataElement[] elems);
		public override void Update();
		public override void SetCP(int index, int value);
		public override IconType GetIconType();
	}
}
