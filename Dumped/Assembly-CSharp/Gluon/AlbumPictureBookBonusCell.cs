/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Http;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AlbumPictureBookBonusCell : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Image icon;
		[SerializeField]
		private UnityEngine.UI.Text facilityName;
		[SerializeField]
		private FacilityDialogContent facilityDialogContent;
	
		// Constructors
		public AlbumPictureBookBonusCell();
	
		// Methods
		public void SetContentElementChara(AtgenElementBonus elementParam);
		public void SetContentElementDragon(AtgenElementBonus elementParam);
		private void LoadIconPrefab(string path);
	}
}
