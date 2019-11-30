data = [
    {"id": "111", "name": "phone", "cost": 10000, "brand": "onePlus", "rating": "5", "discount": "20",
     "category": "electronics"},
    {"id": "222", "name": "shirt", "cost": 2000, "brand": "Tommy", "rating": "5", "discount": "15",
     "category": "clothing"},
    {"id": "333", "name": "shirt", "cost": 1500, "brand": "USPA", "rating": "3", "discount": "30",
     "category": "clothing"},
    {"id": "444", "name": "pant", "cost": 2000, "brand": "levi's", "rating": "4", "discount": "20",
     "category": "clothing"},
    {"id": "555", "name": "toaster", "cost": 5000, "brand": "philips", "rating": "3", "discount": "25",
     "category": "electronics"},
    {"id": "666", "name": "earphones", "cost": 2000, "brand": "skullcandy", "rating": "2", "discount": "40",
     "category": "electronics"},
    {"id": "777", "name": "phone", "cost": 20000, "brand": "iphone", "rating": "4", "discount": "10",
     "category": "electronics"}

]
i = -1
while i != 0:
    print("1. to filter by category")
    print("2. to filter by brand")
    print("3. to filter by name")
    print("0. Exit")
    i = int(input("Enter your option : "))
    f = input("Enter the filter name : ")
    if i == 1:
        newd = filter(lambda ele: ele["category"] == f, data)
        for d in newd:
            print(d)
    elif i == 2:
        newd = filter(lambda ele: ele["brand"] == f, data)
        for d in newd:
            print(d)
    elif i == 3:
        newd = filter(lambda ele: ele["brand"] == f, data)
        for d in newd:
            print(d)
    else:
        break