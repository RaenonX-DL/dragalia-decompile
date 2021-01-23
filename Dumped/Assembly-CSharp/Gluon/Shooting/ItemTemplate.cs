/*
 * Generated code file by Il2CppInspector - http://www.djkaty.com - https://github.com/djkaty
 */

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

// Image 55: Assembly-CSharp.dll - Assembly: Assembly-CSharp, Version=0.0.0.0, Culture=neutral, PublicKeyToken=null

namespace Gluon.Shooting
{
	public class ItemTemplate : MonoBehaviour
	{
		// Fields
		[Header]
		[SerializeField]
		public SpriteRenderer image;
		public Transform tf;
		[Header]
		[SerializeField]
		public Sprite[] animationSpriteList;
		public int addScore;
		public int addHardScore;
		public int addPower;
		public int drainR;
		[Header]
		[SerializeField]
		public Sprite[] toScoreSprites;
		public Sprite[] toHardScoreSprites;
		[Header]
		[SerializeField]
		public Item.Phase entryPhase;
		public ItemManager.TemplateType type;
	
		// Constructors
		public ItemTemplate();
	}
}
