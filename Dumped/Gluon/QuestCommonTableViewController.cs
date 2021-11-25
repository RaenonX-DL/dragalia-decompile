using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Gluon
{
	public class QuestCommonTableViewController<T> : TableViewController<T>
	{
		[SerializeField]
		private Text _tableViewTitle;

		private QuestSelectScene.Difficulty _difficulty;

		protected AnimationListOneCol animationListOneCol;

		public QuestSelectScene.Difficulty difficulty
		{
			get
			{
				return default(QuestSelectScene.Difficulty);
			}
			set
			{
			}
		}

		public Text tableViewTitle => null;

		public QuestCommonTableViewData curViewData
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		public virtual void LoadData()
		{
		}

		public int GetTableDataCount()
		{
			return default(int);
		}

		public T GetTableDataByIndex(int index)
		{
			return (T)null;
		}

		public void SetAlphaToCellsList(float alpha)
		{
		}

		public void OnOpen(float eachWaitTime)
		{
		}

		public void OnClose()
		{
		}

		protected void SetupAnimationCell(TableViewCell<T> cell, int index)
		{
		}

		protected void ClearAnimationCells()
		{
		}

		public bool IsOnAnimation()
		{
			return default(bool);
		}
	}
}
