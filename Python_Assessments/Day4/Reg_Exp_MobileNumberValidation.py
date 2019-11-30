import re

num=input("Enter phone\n")
ptncheck='^[6-9]{1}[0-9]{9}$'

if re.search(ptncheck,num):
     print("Valid Mobile Number")
else:
    print("Invalid Mobile Number")