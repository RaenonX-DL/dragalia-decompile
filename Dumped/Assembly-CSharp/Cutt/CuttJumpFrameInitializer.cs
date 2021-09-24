/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class CuttJumpFrameInitializer : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private List<CuttJumpFrameData> jumpFrameDataList;
		public static CuttJumpFrameInitializer instance;
	
		// Constructors
		public CuttJumpFrameInitializer();
		static CuttJumpFrameInitializer();
	
		// Methods
		private void Awake();
		private void OnDestroy();
		public List<CuttJumpFrameData> GetJumpFrameList();
		public CuttJumpFrameData GetJumpData(int jumpId);
	}
}
