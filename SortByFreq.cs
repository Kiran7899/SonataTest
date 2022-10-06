using System;
using System.Collections.Generic;					
public class Program
{
	Dictionary<int,int> Freq = new Dictionary<int,int>();
	public static void Main()
	{
		List<int> arr = new List<int>() {8,8,9,10};
		new Program().SortFreq(arr);
		
		for(int i=0;i<arr.Count;i++)
			Console.WriteLine(arr[i]);
	}
	public void SortFreq(List<int> arr)
	{
		int N = arr.Count;
		
		for(int i=0;i<N;i++)
		{
			if(!Freq.ContainsKey(arr[i]))
			{
				Freq.Add(arr[i],1);	   
			}
			else
			{
				Freq[arr[i]]++;
			}
		}		
		arr.Sort(compare);
	}
	public int compare(int A,int B)
	{
		if(Freq[A] < Freq[B])
			return -1;
		else if(Freq[A] > Freq[B])
			return 1;
		else
			return 0;	
	}
}
