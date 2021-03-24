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
	public class TreasureTimeController : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private UnityEngine.UI.Text treasureTimeRemainText;
		[SerializeField]
		private Image[] treasureImages;
		protected float timeElapsed;
		private EventQuestModel.TreasureTimeType _treasureType;
		private float remain;
		[CompilerGenerated]
		private Action _startedCallback_k__BackingField;
		[CompilerGenerated]
		private Action _endedCallback_k__BackingField;
		private bool isStarted;
	
		// Properties
		public EventQuestModel.TreasureTimeType treasureType { get; set; }
		public Action startedCallback { [CompilerGenerated] get; [CompilerGenerated] set; }
		public Action endedCallback { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public TreasureTimeController();
	
		// Methods
		public void SetContent(int eventId);
		protected void Update();
		private void UpdateSecond();
	}
}
