﻿namespace SpartaDungeon
{
	public class Display
	{
		// constructor
		public Display() {}

		// method
		public int PrintPage(Page page)
		{
			Console.WriteLine((Page.TypeName)(page.Type));
			Console.WriteLine(page.Info);
			Console.WriteLine("");

			int optionCount = 0;

			foreach (string option in page.OptionList)
			{
				Console.WriteLine($"{optionCount++}. {option}");
			}

			int input;

			while (true)
			{
				input = ReadInput(page);
				if (input != Define.wrongInput)
					return input;
				
			}
		}

		private int ReadInput(Page page)
		{
			Console.Write("원하시는 행동을 입력해주세요.\n>>");
			string input = Console.ReadLine();
			if (input.Length == 1)
			{
				int parsedInput;
				if (int.TryParse(input, out parsedInput))
				{
					if ((0 <= parsedInput)
						&& (parsedInput < page.OptionCount()))
					{
						return parsedInput;
					}
				}
			}
			return Define.wrongInput;
		}
	}
}

