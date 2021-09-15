/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class FortCharacterPlaceSetting : MonoBehaviour
	{
		// Fields
		[SerializeField]
		[Tooltip]
		private List<IgnorePlaceCharacterSetting> ignorePlaceCharacterTable;
	
		// Nested types
		[Serializable]
		private class IgnorePlaceCharacterSetting
		{
			// Fields
			[Tooltip]
			public IgnorePlaceType placeType;
			[Tooltip]
			public List<int> characterIdList;
	
			// Constructors
			public IgnorePlaceCharacterSetting();
		}
	
		public enum IgnorePlaceType
		{
			None = 0,
			ShortDistanceTrainingArea = 1,
			LongDistanceTrainingArea = 2,
			CookingArea = 3
		}
	
		// Constructors
		public FortCharacterPlaceSetting();
	
		// Methods
		public List<int> GetIgnorePlaceCharacterList(FortCharaArrangeController.PlaceType placeType);
	}
}
