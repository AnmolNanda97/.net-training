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

fields = {1: ["cost", False], 2: ["cost", True], 3: ["rating", True], 4: ["discount", True], 5: ["discount", False]}
opt = -1
while opt != 0:
    print("1.Sort by cost Low to High")
    print("2.Sort by cost High to Low")
    print("3.Sort by Rating")
    print("4.Sort by Discount High to Low")
    print("5.Sort by Discount Low to High")
    print("0.Exit")
    opt = int(input("Select an Option"))
    if opt != 0:
        listofobj.sort(key=lambda ele: ele.__getattribute__(fields[opt][0]), reverse=(fields[opt][1]))
        for i in listofobj:
            i.disp()