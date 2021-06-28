#Backlog of Python notes and examples
##########

def sum(n):
    if (n <=0):
        return 0
    return n + sum(n-1)

def pairSumSequence(n):
    sum = 0
    for i in range(n):
        sum += pairSum(i, i+1)
    return sum

def pairSum(a, b):
    return a + b







if __name__ == "__main__":
    print ("Calling sum(): " + str(sum(200))) # Takes the number and adds to itself-1 with recursion
    print ("Calling pairSumSequence(): " + str(pairSumSequence(4))) # Takes the number and adds to itself over and over again the amount of times the number is with recursion. n(squared) basically.


    #Output
    ##########
    #Calling sum(): 20100
    #Calling pairSumSequence(): 16