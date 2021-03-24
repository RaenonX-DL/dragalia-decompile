/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class AlbumPlayerRecordListCell : MonoBehaviour
	{
		// Fields
		public Image icon;
		public UnityEngine.UI.Text paramText;
		public Slider paramGauge;
		public CircleOutline outline;
		private const float gaugeMaxValue = 3000f;
		private const float gaugeDispOffsetValue = 90f;
		private const int recordMaxValue = 9999;
	
		// Constructors
		public AlbumPlayerRecordListCell();
	
		// Methods
		public void UpdateCell(AlbumPlayerRecordListCellData cellData);
		public void SetIcon(AlbumPlayerRecordListCellData cellData);
		public void SetGaugeColor(AlbumPlayerRecordListCellData cellData);
	}
}
