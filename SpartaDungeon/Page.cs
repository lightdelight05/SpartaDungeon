﻿namespace SpartaDungeon
{
	public class Page
	{
		// private field
		private int _type;
		private string _info;
		private List<string> _optionList;

		// public property
		public int Type
		{
			get { return _type; }
			set
			{
				if ((-1 < value) && (value < int.MaxValue))
					_type = value;
			}
		}

		public string Info
		{
			get { return _info; }
			set { _info = value; }
		}

		public List<string> OptionList
		{
			get { return _optionList; }
		}

		// enum
		public enum TypeName
		{
			Main,
			Status,
			Inventory,
			Equipment
		}

		// constructor
		public Page()
		{
			_info = "";
			_optionList = new();
		}

		// method
		private void AddOption(string newOption)
		{
			_optionList.Add(newOption);
		}

		public int CountOption()
		{
			return (_optionList.Count);
		}

		public void SetPage(TypeName type)
		{
			switch (type)
			{
				case TypeName.Main:
					SetMain();
					break;
				case TypeName.Status:
					SetStatus();
					break;
				case TypeName.Inventory:
					SetInventory();
					break;
				case TypeName.Equipment:
					SetEquipment();
					break;
			}
		}

		private void SetMain()
		{
			_type = (int)Page.TypeName.Main;
			_info = "스파르타 마을에 오신 여러분 환영합니다.\n"
					+ "이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.";
			AddOption("상태 보기");
			AddOption("인벤토리");
			AddOption("게임 종료");
		}

		private void SetStatus()
		{
			_type = (int)Page.TypeName.Status;
			_info = "캐릭터의 정보가 표시됩니다.";
			AddOption("나가기");
		}

		private void SetInventory()
		{
			_type = (int)Page.TypeName.Inventory;
			_info = "보유 중인 아이템을 관리할 수 있습니다.";
			AddOption("장착 관리");
			AddOption("나가기");
		}

		private void SetEquipment()
		{
			_type = (int)Page.TypeName.Equipment;
			AddOption("나가기");
		}
	}
}

