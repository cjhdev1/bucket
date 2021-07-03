import java.util.Iterator;
import java.util.LinkedList;
import java.util.ListIterator;
import java.util.Stack;

public class LinkedLists {
	public static void main(String[] args)
	{
		LinkedList NamesLinkLists = new LinkedList();
		
		NamesLinkLists.add("John");
		NamesLinkLists.add("Matt");
		NamesLinkLists.add("Chris");
		NamesLinkLists.add("Chad");
		NamesLinkLists.add("Billy");
		
		// [John, Matt, Chris, Chad, Billy]
		System.out.println(NamesLinkLists);
		
		// Get first in linked list
		System.out.println(NamesLinkLists.getFirst());
		
		
		
		LinkedList<Integer> NumberLinkLists = new LinkedList<Integer>();
		
		NumberLinkLists.add(1);
		NumberLinkLists.add(55);
		NumberLinkLists.add(66);
		NumberLinkLists.add(99);
		NumberLinkLists.add(2548);
		
		System.out.println(NumberLinkLists);
		
		// Gets 55 because 1 position of list
		System.out.println(NumberLinkLists.get(1));
		
		Iterator<Integer> it = NumberLinkLists.iterator();
		while(it.hasNext())
		{
			if((int)it.next() == 99)
			{
				System.out.println("We found 99 in the list");
			}
		}
		
		// Checking to see if list is empty
		System.out.println(NumberLinkLists.isEmpty());
		
		// Removes the first item in the linked list
		NumberLinkLists.removeFirst();
		System.out.println(NumberLinkLists);
		
		
		/**********
		 * Output
			[John, Matt, Chris, Chad, Billy]
			John
			[1, 55, 66, 99, 2548]
			55
			We found 99 in the list
			false
			[55, 66, 99, 2548]
		*********/	

	}
}
