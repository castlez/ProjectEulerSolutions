"""
LARGEST PALINDROME PRODUCT (PROJECT EULER 4) (FINISHED)
This program finds the largest palindrom produced by multiplying
two 3-digit numbers.

ALGORITHM
1) hit it with the hammer (brute force)
    searching in the range between 900 and 999
    because the solution is clearly in there 
    somewhere.
"""
import sys
sys.path.insert(0,'../JCPyTools')
import JCPyTools as t
def BruteForce():
    biggest = ""
    for i in range(999,900,-1):
       for j in range(999,900,-1):
           s = str(j*i)
           print("trying " + str(j) + " x " + str(i) + " = " + s +  "...")
           if(checkPalindrome(s)):
               biggest = s
           print("###################the biggest is" + biggest)

def checkPalindrome(s):
    r = s[::-1]
    if(r == s):
        return True
    return False

if __name__ == "__main__":
    t.printw("going to try brute force!...")
    BruteForce()














