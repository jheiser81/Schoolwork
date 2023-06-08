#Intro to Python

#Basic Input/Output
#------------------

#in Python, you don't need to declare the type of variables

from itertools import product
from math import prod


print ("Hello, World!") #just type print and then the text you want to print. So easy!

#myNumber = 3 #No need to declare the type of variable. Just type the name and the value and you are done!   
#print (myNumber)

#myNumber2 = 4.5
#print (myNumber2)

#sum = myNumber + myNumber2 #in Python, sum is a keyword, so you can't use it as a variable name
#print (sum)

##-------------------

#nums = [] #create an empty list

#nums.append(21) #.append() is a method of the list class. This method adds an element to the end of the list
#nums.append(40.5)
#nums.append("String")

#print (nums)

#print (nums[0]) #print the first element of the list

#print (nums[1]) #print the second element of the list

##----------------------

#name = input("Enter you name:") #input() is a function that takes a string as an argument and returns the user input as a string

#print ("Hello, " + name) #concatenate strings

#print ("Hello, %s" % name) # %s is a placeholder for a string

##----------------------

#num1 = int(input("Enter a number:"))#int is a function that takes a string as an argument and returns the integer value of the string
#num2 = int(input("Enter another number:"))

#product = num1 * num2 #product is a keyword, so you can't use it as a variable name
#print ("Product is: ", product)

##\n is a special character that represents a new line

##VARIABLES
##---------

##A Variable is a container that stores a value. Python is not “statically typed”. We do not need to declare variables before using them or declare their type. A variable is created the moment we first assign a value to it. A Python variable is a name given to a memory location. It is the basic unit of storage in a program.

##Rules for Python variables
##A Python variable name must start with a letter or the underscore _ character.
##A Python variable name cannot start with a number.
##A Python variable name can only contain alpha-numeric characters and underscores (A-z, 0-9, and _ ).
##Variables in Python names are case-sensitive (name, Name, and NAME are three different variables).
##The reserved words(keywords) in Python cannot be used to name a variable in Python.

#var = "Hello, Variable" #I am assigning a string value to the variable var
#print (var)

##valid names
#geeks = 1
#Geeks = 2
#GEEKS =3
#Ge_e_ks = 4
#_geeks = 5
#_GEEKS_ = 6
#print (geeks, Geeks, GEEKS)
#print (Ge_e_ks, _geeks, _GEEKS_)

##--------------------------------

#age = 45 #integer
#salary = 1456.8 #floating point number
#name = "John"#string

#print (age, salary, name)

##--------------------------------

## declaring the variable
#Number = 100

## display
#print("Before declare: ", Number)

## re-declare the variable
#Number = 120.3

#print("After re-declare:", Number)

#----------------------------------

#a = b = c = 10 #python allows assigning the same value to multiple variables at the same time

#print(a)
#print(b)
#print(c)

#----------------------------------

#x = 10
#y = 20
#print(x+y) #in this case, the + operator is used to add two numbers

#x = "Geeksfor"
#y = "Geeks"
#print(x+y) #in this case, the + operator is used to concatenate two strings

#can't concatenate a string and a number with the + operator

#----------------------------------

# This function uses global variable s
def f():
	s = "Welcome geeks"
	print(s)


f()

#----------------------------------

# This function has a variable with
# name same as s.
def f():
	print(s)


# Global scope
s = "I love Geeksforgeeks"
f()
