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
	public class FortTalkBalloon : MonoBehaviour
	{
		// Fields
		[SerializeField]
		private GameObject objectLSize;
		[SerializeField]
		private GameObject objectMSize;
		[SerializeField]
		private UnityEngine.UI.Text characterNameTextM;
		[SerializeField]
		private UnityEngine.UI.Text talkTextM;
		[SerializeField]
		private UnityEngine.UI.Text characterNameTextL;
		[SerializeField]
		private UnityEngine.UI.Text talkTextL;
		[SerializeField]
		private Transform posNode;
		[CompilerGenerated]
		private GameObject _onwer_k__BackingField;
		private readonly Vector3 headPos;
	
		// Properties
		public GameObject onwer { [CompilerGenerated] get; [CompilerGenerated] set; }
	
		// Constructors
		public FortTalkBalloon();
	
		// Methods
		private void Start();
		private void LateUpdate();
		public void OpenText(string name, string text);
		public void CloseText();
		private void SetText(string text, string name);
		private void Enable();
		private void Disable();
	}
}
