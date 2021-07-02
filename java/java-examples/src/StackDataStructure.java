import java.util.*;

public class StackDataStructure {
	public static void main(String[] args)
	{
		Stack<String> exampleStack = new Stack<>();
		exampleStack.push("Example 1");
		exampleStack.push("Example 2");
		exampleStack.push("Example 3");
		exampleStack.push("Example 4");
		exampleStack.push("Example 5");
		
		exampleStack.pop(); // The initial stack was 5 but now all below it will be 4 after this pop
		
		System.out.println("Size of stack: " + exampleStack.size());
		System.out.println("Peek: " + exampleStack.peek());
		
		int searchStack = exampleStack.search("Example 4");
		System.out.println("Example stack search found here: " + searchStack);
		
		// This will print the stack from the bottom up (first in to last in)
		for (Iterator iterator = exampleStack.iterator(); iterator.hasNext();) {
			String string = (String) iterator.next();
			System.out.println("Test1: " + string);
		}
		
		// Another way to print the stack from the bottom up (first in to last in)
		for (String s : exampleStack)
		{
			System.out.println("Test2: " + s);
		}
		
		// Print the stack from the top down (last in to first in)
		ListIterator<String> listIterator = exampleStack.listIterator(exampleStack.size());
		while (listIterator.hasPrevious())
		{
			String previous = listIterator.previous();
			System.out.println("Test3: " + previous);
		}
	}
}

/*********
Output

Size of stack: 4
Peek: Example 4
Example stack search found here: 1
Test1: Example 1
Test1: Example 2
Test1: Example 3
Test1: Example 4
Test2: Example 1
Test2: Example 2
Test2: Example 3
Test2: Example 4
Test3: Example 4
Test3: Example 3
Test3: Example 2
Test3: Example 1

*********/