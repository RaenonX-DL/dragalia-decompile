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
	public class FortArrangedCharaWatcher : MonoBehaviour
	{
		// Fields
		private List<FortCharaActionController> charaActionControllerList;
		private const int VOICE_MAX_SOURCE_COUNT = 14;
		private List<string> loadedVoiceGroupNameList;
	
		// Constructors
		public FortArrangedCharaWatcher();
	
		// Methods
		private void Start();
		public void AddToCharaList(FortCharaActionController charaActionController);
		public void ClearCharaList(FortCharaActionController charaActionController);
		private void BeforeLoadVoice(string voiceGroupName);
		public bool IsJammedCharaExist(Vector3 basePos, Vector3 forward, float checkDist, float checkAngle, out float foundDist);
	}
}
