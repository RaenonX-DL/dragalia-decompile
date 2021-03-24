/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cute.Cri;
using Gluon.Master;
using UnityEngine;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class UnitDetailAlbumMemoryPopup : PopupBase
	{
		// Fields
		public Dictionary<MemoryType, string> memoryData;
		[SerializeField]
		private GameObject memoryButtonPrefab;
		[SerializeField]
		private Transform scrollViewContent;
		private CharaDataElement masterCharaData;
		private string[] voiceGroupName;
		private AudioPlayback soundPlayBack;
		private Camera flashCamera;
		public UnitDetailScene scene;
	
		// Nested types
		public enum MemoryType
		{
			summon = 0,
			awaking = 1,
			awakingSecond = 2,
			win = 3,
			questFailed = 4,
			dead = 5
		}
	
		// Constructors
		public UnitDetailAlbumMemoryPopup();
	
		// Methods
		public static UnitDetailAlbumMemoryPopup Create(UnitDetailModel.CharaDetailData data, Camera flashCamera, bool showBlackLayer = true);
		protected override void Start();
		public void InitContents(UnitDetailModel.CharaDetailData data, Camera camera);
		protected override void OnDestroy();
		public void OnMemoryButtonPressed(MemoryType type);
		private void OnSummonButtonpressed();
		private void OnAwakingButtonPressed();
		private void OnAwakingButtonSecondPressed();
		private void OnWinButtonpressed();
		private void OnQuestFailedButtonpressed();
		private void OnDeadButtonpressed();
		[CompilerGenerated]
		private void _OnSummonButtonpressed_b__14_0();
	}
}
