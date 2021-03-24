/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AlbumCommonUnitIcon : CommonUnitIcon
	{
		// Fields
		[SerializeField]
		private Image bonusClearIcon;
		[SerializeField]
		private Image bonusCompleteIcon;
	
		// Nested types
		public enum IconStatus
		{
			None = 0,
			Possession = 1,
			bonusClear = 2,
			bonusComplete = 3
		}
	
		// Constructors
		public AlbumCommonUnitIcon();
	
		// Methods
		public void SetIconStatus(IconStatus status);
	}
}
