/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class CuttReplaceSoundInitializer : MonoBehaviour
	{
		// Fields
		public static CuttReplaceSoundInitializer instance;
		[SerializeField]
		public List<CuttReplacePartyCharaSoundInfo> replaceInfoList;
		private CuttCharacterInitializer characterInitializer;
	
		// Constructors
		public CuttReplaceSoundInitializer();
		static CuttReplaceSoundInitializer();
	
		// Methods
		private void Awake();
		public string GetReplaceSoundLabel(string originalLabel);
	}
}
