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
	public class StoryBgToCharaColorTable : ScriptableObject
	{
		// Fields
		private const string fileName = "StoryBgToCharaColorTable";
		private const string resourcesPath = "Images/Story/StoryBgToCharaColorTable";
		private const string assetPath = "Assets/_GluonResources/Resources/Images/Story/StoryBgToCharaColorTable";
		[CompilerGenerated]
		private static StoryBgToCharaColorTable _Instance_k__BackingField;
		[SerializeField]
		private List<StoryBgToCharaColorTableElement> list;
	
		// Properties
		public static StoryBgToCharaColorTable Instance { [CompilerGenerated] get; [CompilerGenerated] private set; }
		public List<StoryBgToCharaColorTableElement> List { get; }
	
		// Constructors
		public StoryBgToCharaColorTable();
	
		// Methods
		public static void Load();
	}
}
