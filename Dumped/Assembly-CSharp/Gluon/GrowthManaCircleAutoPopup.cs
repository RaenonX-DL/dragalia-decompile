/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Gluon.Master;
using UnityEngine;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class GrowthManaCircleAutoPopup : CommonPopup
	{
		// Fields
		public UnityEngine.UI.Text currentMPNum;
		public UnityEngine.UI.Text afterMPNum;
		public UnityEngine.UI.Text currentMPNumDouble;
		public UnityEngine.UI.Text afterMPNumDouble;
		public UnityEngine.UI.Text currentDewNumDouble;
		public UnityEngine.UI.Text afterDewNumDouble;
		public GameObject singleNode;
		public GameObject doubleNode;
		public RectTransform scrollView;
		public GameObject scrollViewContent;
		public GameObject statusLabel;
		public GameObject skillLabel;
		public GameObject paramLabel;
		public UnityEngine.UI.Text skillText;
		public UnityEngine.UI.Text label2;
		public UnityEngine.UI.Text label2mana;
		public UnityEngine.UI.Text label2dew;
		public UnityEngine.UI.Text requiredMPNum;
		public UnityEngine.UI.Text requiredMPNumDouble;
		public UnityEngine.UI.Text requiredDewNumDouble;
		public CommonIcon[] icons;
		public Image[] requiredLabels;
		public UnityEngine.UI.Text[] requiredNumText;
		public Image[] havingLabels;
		public UnityEngine.UI.Text[] havingNumText;
		public UnityEngine.UI.Text[] havingText;
		public UnityEngine.UI.Text warningText;
	
		// Nested types
		private class MaterialEntity
		{
			// Fields
			public MaterialDataElement element;
			public int havingNum;
			public int requiredNum;
	
			// Constructors
			public MaterialEntity();
		}
	
		// Constructors
		public GrowthManaCircleAutoPopup();
	
		// Methods
		public static GrowthManaCircleAutoPopup Create(bool isMaterialNeeded);
		public void SetParameters(int num, int requiredMP, int currentMP);
		public void SetParametersDouble(int num, int requiredMP, int currentMP, int requiredDew, int currentDew);
		public void SetContent(GrowthManaCircleModel model, List<GrowthManaCircleManaPieceData> dataList);
	}
}
