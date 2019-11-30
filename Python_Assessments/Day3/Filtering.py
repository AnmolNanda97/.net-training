data = [
    {"id": "111", "name": "phone", "cost": 10000, "brand": "onePlus", "rating": 5, "discount": 20,
     "category": "electronics"},
    {"id": "222", "name": "shirt", "cost": 2000, "brand": "Tommy", "rating": "5", "discount": 15,
     "category": "clothing"},
    {"id": "333", "name": "shirt", "cost": 1500, "brand": "USPA", "rating": 3, "discount": 30,
     "category": "clothing"},
    {"id": "444", "name": "pant", "cost": 2000, "brand": "levi's", "rating": 4, "discount": 20,
     "category": "clothing"},
    {"id": "555", "name": "toaster", "cost": 5000, "brand": "philips", "rating": 3, "discount": 25,
     "category": "electronics"},
    {"id": "666", "name": "earphones", "cost": 2000, "brand": "skullcandy", "rating": 2, "discount": 40,
     "category": "electronics"},
    {"id": "777", "name": "phone", "cost": 40000, "brand": "iphone", "rating": 4, "discount": 10,
     "category": "electronics"}

]


class Product:
    def __init__(self, id, name, cost, brand, rating, discount, category):
        self.id = id
        self.name = name
        self.cost = cost
        self.brand = brand
        self.rating = rating
        self.discount = discount
        self.category = category

    def disp(self):
        print(self.id, " ", self.name, " ", self.brand, " ", self.cost)


listofobj = []

for d in data:
    listofobj.append(Product(**d))

inp = -1
while inp != 0:
    print("Press 1. to filter by category")
    print("Press 2. to filter by brand")
    print("Press 3. to filter by name")
    print("Press 0 to exit")
    inp = int(input("Enter your option : "))
    f = input("Enter the filter name : ")
    if inp == 1:
        newd = filter(lambda ele: ele["category"] == f, data)
        for d in newd:
            print(d)
    elif inp == 2:
        newd = filter(lambda ele:  ele["brand"] == f, data)
        for d in newd:
            print(d)
    elif inp == 3:
        newd = filter(lambda ele:  ele["name"] == f, data)
        for d in newd:
            print(d)
    else:
        break