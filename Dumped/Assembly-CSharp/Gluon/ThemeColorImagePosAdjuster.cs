/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon
{
	[DisallowMultipleComponent]
	[RequireComponent]
	public class ThemeColorImagePosAdjuster : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public Vector3 mypagePos;
		[SerializeField]
		public Vector3 growthPos;
		[SerializeField]
		public Vector3 partyPos;
		[SerializeField]
		public Vector3 fortPos;
		[SerializeField]
		public Vector3 summonPos;
		[SerializeField]
		public Vector3 menuPos;
		[SerializeField]
		public Vector3 eventPos;
		private Image _image;
	
		// Properties
		private Image image { get; }
	
		// Constructors
		public ThemeColorImagePosAdjuster();
	
		// Methods
		private void Start();
		public void ApplyPosition();
	}
}
