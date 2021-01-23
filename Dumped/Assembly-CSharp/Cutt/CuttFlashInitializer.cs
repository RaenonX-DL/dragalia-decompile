/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Cutt
{
	public class CuttFlashInitializer : MonoBehaviour
	{
		// Fields
		[SerializeField]
		public List<CuttFlashInitializeData> initializeDataList;
		private bool isInitialized;
		private bool isPlayingInGame;
	
		// Constructors
		public CuttFlashInitializer();
	
		// Methods
		public CuttFlashController GetFlashController(int index);
		public bool IsInitialized();
		public void Load(bool isPlayingInGame, GameObject canvasObject);
		private CuttFlashController LoadFlash(CuttFlashInitializeData initData, GameObject canvasObject, int index);
		private void OnDestroy();
	}
}
