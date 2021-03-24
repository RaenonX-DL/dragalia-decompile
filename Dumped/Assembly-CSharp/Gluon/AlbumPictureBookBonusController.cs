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
	public class AlbumPictureBookBonusController : TabContentBase
	{
		// Fields
		[Header]
		[SerializeField]
		public FortMenuGroupType facilityGroup;
		[SerializeField]
		protected RectTransform prefab;
		[SerializeField]
		protected Transform contentParent;
	
		// Constructors
		public AlbumPictureBookBonusController();
	
		// Methods
		private void Start();
		private bool IsFortPlantTypeExist(FortPlantType type);
		private AlbumPictureBookBonusCell CreateFortDetailCell();
	}
}
