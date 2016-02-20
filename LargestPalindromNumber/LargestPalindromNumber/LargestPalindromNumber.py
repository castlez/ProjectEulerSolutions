"""
LARGEST PALINDROME PRODUCT (PROJECT EULER 4) (UNFINISHED)
This program finds the largest palindrom produced by multiplying
two 3-digit numbers.

ALGORITHM
1) hit it with the hammer (brute force)
    searching in the range between 900 and 999
    because the solution is clearly in there 
    somewhere.
"""
import msvcrt as m
def BruteForce():
    biggest = ""
    for i in range(999,950,-1):
       for j in range(999,950,-1):
           s = str(j*i)
           print("trying " + str(j) + " x " + str(i) + " = " + s +  "...")
           wait()
           if(checkPalindrome(s)):
               biggest = str(i*j)
           print("###################the biggest is" + biggest)

def checkPalindrome(s):
    r = s[::-1]
    if(r == s):
        return True
    return False

def wait():
    m.getch()

def printw(s):
    print(s)
    wait()

if __name__ == "__main__":
    printw("going to try brute force!...")
    BruteForce()














