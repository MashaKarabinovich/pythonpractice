#!/bin/python
#Python If-Else - Hacker Rank Solution
import math
import os
import random
import re
import sys

if __name__ == '__main__':
    n = int(raw_input().strip())
    
    if n%2 != 0:
        print("Weird") #odd
    else :
        if(n>=2 and n<=5): #between 2 and 5
            print("Not Weird")
        elif(n>=6 and n<=20): #between 6 and 20
            print("Weird")
        elif(n>20):
            print("Not Weird") #even and greater than 20
