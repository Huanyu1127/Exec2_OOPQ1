using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ispan.Utilities._1A2B
{
	public class GetNumber
	{
		public string[] GetRandom()
		{
			var random = new Random();
			int randomNumber = random.Next(0, 10);
			int[] randomArray = new int[10];
			
			int temp = -1;
			for (int i = 0; i < randomArray.Length; i++)
			{
				randomArray[i] = i;
			}
			//{0,1,2,3,4,5,6,7,8,9}
			for(int i = 0; i < randomArray.Length; i++)
			{
				randomNumber = random.Next(0, 10);
				temp = randomArray[randomNumber];
				randomArray[randomNumber] = randomArray[i];
				randomArray[i] = temp;
			}
			//int[] answer = { randomArray[0], randomArray[1], randomArray[2], randomArray[3] };
			string[] answer = { randomArray[0].ToString(), randomArray[1].ToString(), randomArray[2].ToString(), randomArray[3].ToString() };
			return answer;
		}
		public string[] GetInput(string input)
		{
			bool isInt=int.TryParse(input, out int value);
			string inputNumber = isInt ? value.ToString() : throw new Exception("請輸入數字");
			string[] inputArray = { input.Substring(0, 1), input.Substring(1, 1), input.Substring(2, 1), input.Substring(3, 1) };
			HashSet<string> answer = new HashSet<string>();
			for (int i = 0; i < inputArray.Length; i++)
			{
				answer.Add(inputArray[i]);
			}
			if (answer.Count < 4) throw new Exception("請輸入四個不重複的數字");
			return inputArray;
		}
	}
}
