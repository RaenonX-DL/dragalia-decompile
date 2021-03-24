/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AlbumPictureListController : CommonIconListController
	{
		// Fields
		private CommonIconListType commonIconType;
		private CommonSortModel.Preset preset;
	
		// Constructors
		public AlbumPictureListController();
	
		// Methods
		public void LoadData(CommonIconListType type);
		public void OnSortButtonClicked();
		public void OnSortApplied();
		private List<ulong> CreateDataIdList(CommonIconListType type);
		protected AlbumCommonIconCellData CreateAlbumCharacterCellData(int keyIdOrInvalidId);
		protected T SetupCharacterCellData<T>(int keyId)
			where T : AlbumCommonIconCellData, new();
		protected AlbumCommonIconCellData CreateAlbumDragonCellData(int keyIdOrInvalidId);
		protected T SetupDragonCellData<T>(int keyId)
			where T : AlbumCommonIconCellData, new();
	}
}
