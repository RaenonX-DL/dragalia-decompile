/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

// Image 58: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	public class StoryViewBase : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private Button storyTabButton;
		[SerializeField]
		private Button eventTabButton;
		[SerializeField]
		private GameObject StoryListView;
		public UnityAction<StoryListCategory> tabButtonAction;
		public UnityAction<StoryListCellData> listButtonCallBack;
	
		// Constructors
		public StoryViewBase();
	
		// Methods
		private void Start();
		public void StoryTabEnable();
		public void EventTabEnable();
		public void SetStoryViewActive(bool active);
	}
}
