import java.util.LinkedList;
import java.util.Queue;

public class QExample {

	public static void main(String[] args) {
		Queue<String> NewQueue = new LinkedList<String>();

		NewQueue.add("InLine-1");
		NewQueue.add("InLine-2");
		NewQueue.add("InLine-3");
		NewQueue.add("InLine-4");
		NewQueue.add("InLine-5");
		
		// [InLine-1, InLine-2, InLine-3, InLine-4, InLine-5]
		System.out.println(NewQueue);
		
		NewQueue.poll(); // Removes first in line from the queue
		
		// [InLine-2, InLine-3, InLine-4, InLine-5]
		System.out.println(NewQueue);
		
		// InLine-2
		System.out.println(NewQueue.peek()); // Will show InLine-2 but not take it out of queue like poll does
		
		// Prints the size of the queue left which is "4"
		System.out.println(NewQueue.size());
		
		// true because it found "InLine-4" in the queue
		System.out.println(NewQueue.contains("InLine-4"));
		
		// Turn queue into an array() to get a value as well
		// "InLine-5" here
		System.out.println(NewQueue.toArray()[3]);
	}

}
