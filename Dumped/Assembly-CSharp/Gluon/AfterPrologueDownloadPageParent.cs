/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AfterPrologueDownloadPageParent : MonoBehaviour
	{
		// Fields
		public int myIndex;
		private AfterPrologueDownloadTutorialPage tutorialPage;
		private AfterPrologueDownloadCharaDetailPage charaPage;
		private string tutorialPrefabPath;
		private string charaPrefabPath;
	
		// Constructors
		public AfterPrologueDownloadPageParent();
	
		// Methods
		private void Awake();
		public void ShowTutorialPage();
		public void ShowCharaPage(int charaId);
	}
}
