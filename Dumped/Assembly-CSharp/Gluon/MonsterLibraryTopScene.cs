/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class MonsterLibraryTopScene : SceneBase
	{
		// Fields
		public GameObject bgPanel;
		public Canvas mainCanvas;
		private MonsterLibraryListController monsterLibraryListController;
		private MonsterLibraryListSort nowSort;
	
		// Constructors
		public MonsterLibraryTopScene();
	
		// Methods
		private void Start();
		private void BackButtonPressed();
		private void SortButtonPressed();
		private void MonsterIconPressed(int selectMonsterID);
	}
}
