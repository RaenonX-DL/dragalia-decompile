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
	public class RaidPlayerUI : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		private UnityEngine.UI.Text label;
		[SerializeField]
		private InGameGaugeUISpriteRenderer gaugeHP;
		[SerializeField]
		private Image[] mark;
		[Header]
		[SerializeField]
		private Sprite onMark;
		[SerializeField]
		private Sprite offMark;
		[SerializeField]
		private Image playerNoImage;
		[SerializeField]
		private Sprite[] playerNo;
		[Header]
		[SerializeField]
		private Color32[] playerColor;
		private SandTimerUI sandTimerUI;
		private static readonly Vector3 SAND_TIMER_POS;
	
		// Constructors
		public RaidPlayerUI();
		static RaidPlayerUI();
	
		// Methods
		public static GameObject LoadPrefab();
		public static RaidPlayerUI Create(GameObject prefab, GameObject parent, int siblingIndex = -1);
		private void Initialize();
		public void Active(bool b);
		public void SetName(string name, int index, int numTotal);
		public void SetInfo(int numLiving, float value);
		public void CreateSandTimerUI();
		public void ShowSandTimerUI();
		public void HideSandTimerUI();
		public void SetSandTimerUICount(int count);
		public void SetSandTimerUICountColor(SandTimerUI.CountColorType type);
	}
}
