a= int(input("Enter the number of terms: "))

x=0
y=1
count = 0

if a <= 0:
   print("Invalid Input. Enter number > 0")
elif a == 1:
   print("The fibonacci series result for",a,"terms is :")
   print(x)
else:
   print("The fibonacci series result for",a,"terms is :")
   while count < a:
       print(x)
       z = x + y
       
       x = y
       y = z
       
       count += 1