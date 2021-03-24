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
	public class SummonOddsPopupItemLine : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public Image elementalIcon;
		public Image weaponTypeIcon;
		[Header]
		[SerializeField]
		public GameObject elementalTypeGO;
		public GameObject weaponTypeGO;
		public GameObject pickupGO;
		[Header]
		[SerializeField]
		public UnityEngine.UI.Text itemName;
		public UnityEngine.UI.Text percentage;
		[Header]
		[SerializeField]
		public GameObject captionNode;
		public GameObject normalNode;
		public UnityEngine.UI.Text captionText;
		public const float captionHeight = 48f;
		public const float normalHeight = 32f;
		private static GameObject prefab;
	
		// Constructors
		public SummonOddsPopupItemLine();
		static SummonOddsPopupItemLine();
	
		// Methods
		public static GameObject LoadPrefab();
		public static void ReleasePrefab();
		public void SetupByData(SummonOddsTableViewData data);
	}
}
